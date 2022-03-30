// Upgrade NOTE: replaced '_LightMatrix0' with 'unity_WorldToLight'

// Upgrade NOTE: replaced '_LightMatrix0' with 'unity_WorldToLight'

// Upgrade NOTE: replaced '_Object2World' with 'unity_ObjectToWorld'

// Upgrade NOTE: replaced '_Object2World' with 'unity_ObjectToWorld'

// Upgrade NOTE: commented out 'float4 unity_LightmapST', a built-in variable
// Upgrade NOTE: commented out 'sampler2D unity_Lightmap', a built-in variable

// Upgrade NOTE: replaced tex2D unity_Lightmap with UNITY_SAMPLE_TEX2D

// Upgrade NOTE: commented out 'float4 unity_LightmapST', a built-in variable
// Upgrade NOTE: commented out 'sampler2D unity_Lightmap', a built-in variable

// Upgrade NOTE: replaced tex2D unity_Lightmap with UNITY_SAMPLE_TEX2D

// Upgrade NOTE: replaced tex2D unity_Lightmap with UNITY_SAMPLE_TEX2D

// Upgrade NOTE: commented out 'sampler2D unity_Lightmap', a built-in variable
// Upgrade NOTE: replaced tex2D unity_Lightmap with UNITY_SAMPLE_TEX2D

Shader "Custom Shaders/DefaultShader"
{
    Properties
    {
        _MainTex ("Texture", 2D) = "white" {}
		_Colour("Colour", Color) = (1,1,1,1)
		_Cutoff("Alpha cutoff", Range(0,1)) = 0.5
		_NormalMap ("Normal Map", 2D) = "white"{}
		_NormalStrength ("Normal Strength", Int) = 1
		_Brightest("Brightest", Int) = 1
		_Darkest("Darkest", Int) = 0.5
		_ColourRamp("Colour Ramp", 2D) = "white" {}
		_Emission("Emission", Color) = (0,0,0,1)
		_LightDirection("Light Direction", Vector) = (0.5,0,-0.5)
    }
    SubShader
    {
		Tags {"Queue" = "AlphaTest" "IgnoreProjector" = "True" "RenderType" = "TransparentCutout"}
        LOD 500

        Pass
        {
			Tags { "LightMode" = "ForwardBase" }

            CGPROGRAM
			#pragma multi_compile_fwdbase 
			#pragma multi_compile_instancing

            #pragma vertex vert
            #pragma fragment frag

            #include "UnityCG.cginc"
			#include "Lighting.cginc"
			#include "AutoLight.cginc"

            struct appdata
            {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
				float3 normal : NORMAL;
            };

            struct v2f
            {
				float4 pos : SV_POSITION;
				float2 uv : TEXCOORD0;
				float3 worldNormal : TEXCOORD1;
				SHADOW_COORDS(2)
				half4 worldPos : TEXCOORD3;
            };

            sampler2D _MainTex;
			sampler2D _NormalMap;
			sampler2D _ColourRamp;

			fixed _Cutoff;
			float1 _Brightest;
			float1 _Darkest;
			float1 _NormalStrength;

			float4 _LightDirection;

            float4 _MainTex_ST;

			float4 _Colour;
			float4 _Emission;

            v2f vert (appdata v)
            {
                v2f o;
				UNITY_INITIALIZE_OUTPUT(v2f, o);
				o.pos = UnityObjectToClipPos(v.vertex);
				o.uv = TRANSFORM_TEX(v.uv, _MainTex);
				o.worldNormal = UnityObjectToWorldNormal(v.normal);
				o.worldPos = mul(unity_ObjectToWorld, v.vertex);
				TRANSFER_SHADOW(o);
                return o;
            }

            fixed4 frag (v2f i) : SV_Target
            {
				_LightDirection = _WorldSpaceLightPos0;
				UNITY_LIGHT_ATTENUATION(atten, i, i.pos);
				float3 finalNormal = abs(i.worldNormal + (UnpackNormal(tex2D(_NormalMap, i.uv) * _NormalStrength) * 0.5f + 0.5f));
				float3 spotLightIntensity = 1 / distance(float3(unity_4LightPosX0.x, unity_4LightPosY0.x, unity_4LightPosZ0.x), i.worldPos.xyz + finalNormal) * (1 / unity_4LightAtten0.x);
				fixed4 shading = tex2D(_ColourRamp, dot(finalNormal * _Brightest + _Darkest * atten, _LightDirection)) * _LightColor0;
				fixed4 col = tex2D(_MainTex, i.uv) * _Colour;
				#if SHADOWS_SCREEN
					col.rgb *= shading;
				#endif
				col.rgb += _Emission;
				col.rgb += unity_LightColor[0].rgb * tex2D(_ColourRamp, abs(spotLightIntensity));
				clip(col.a - _Cutoff);
                return col;
            }
            ENDCG
        }
		Pass
		{
			Name "ShadowCaster"
			Tags { "LightMode" = "ShadowCaster" }

			ZWrite On ZTest LEqual Cull Off

			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			#pragma target 2.0
			#pragma multi_compile_shadowcaster
			#pragma multi_compile_instancing
			#include "UnityCG.cginc"

			struct v2f {
				V2F_SHADOW_CASTER;
				UNITY_VERTEX_OUTPUT_STEREO
			};

			v2f vert( appdata_base v )
			{
				v2f o;
				UNITY_SETUP_INSTANCE_ID(v);
				UNITY_INITIALIZE_VERTEX_OUTPUT_STEREO(o);
				TRANSFER_SHADOW_CASTER_NORMALOFFSET(o)
				return o;
			}

			float4 frag( v2f i ) : SV_Target
			{
				SHADOW_CASTER_FRAGMENT(i)
			}
			ENDCG
		}
	}
}
