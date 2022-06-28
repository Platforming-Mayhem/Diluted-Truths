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

-> Distrust_Highest

=== Distrust_Highest ===
I can already feel we’re a major contributor to those deaths. It’s always just terrible feelings from our side of the war. 
The same civilians we seem to pride ourselves in taking in from refuge are the same that we seem to be massacring with no discretion.
-> END

=== PublicOp_Highest ===
It must be them. We use drones sparingly as well as take civilians as a number one priority. 
Sure, there’s a case to be made for perhaps a few deaths being our cause however that’s the risk with war unfortunately. 
This is why, I think once it’s over Lebiasto will be in a much better state without a dictator.
-> END

=== PublicUnrest_Highest ===
I can already feel we’re a major contributor to those deaths. It’s always just terrible feelings from our side of the war. 
The same civilians we seem to protesting for equal rights seem to be the same they keep murdering cold heartedly. Where will this all end?
-> END