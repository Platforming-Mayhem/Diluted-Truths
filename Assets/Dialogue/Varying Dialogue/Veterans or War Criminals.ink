INCLUDE ..\globals.ink

{gov_distrust > public_unrest:
  {gov_distrust> public_opinion: -> Distrust_Highest}
}

{public_opinion > gov_distrust:
  {public_opinion>public_unrest: -> PublicOp_Highest}
}

{public_unrest > gov_distrust:
  {public_unrest>public_opinion: -> PublicUnrest_Highest}
}

=== Distrust_Highest ===
All of them wouldn’t last in any modern military. Youth go in, just to be moulded by the old guard like clay. 
For even 10 reals, you can just about slip away with anything mild. They aren’t trained in conventional warfare but most of them don’t seem to care. 
It’s as if all they know is torture and yet that costs us also.
-> END

=== PublicOp_Highest ===
No….. surely not. 60%? War criminals? You’re telling me that my uncle who just came back could have…. Never. But, they don’t get their facts wrong about this company. 
This is all too much to take in. What kind of things just go on the frontlines? 
Now that I think about it, Uncle doesn't have any serious physical scars... but looking into his eyes… I feel as if he’s seen things now…. Done things…. 
No man should ever in their lifetime.
-> END

=== PublicUnrest_Highest ===
Get rid of them. All of them. Scum of the earth for the way they treat human life. 
All for what? A couple of badges and a bump to their paycheck. It’s inhumane the way they think in fact.
-> END