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
The government silently assassinating our Agriculture industry. Wow.
I know somehow because people didn't switch to the all new industrial way they're gonna find a way to force them.
-> END

=== PublicOp_Highest ===
I’m sure it’ll be fine. Agriculture usually shoots right back up during situations like this. This is the norm we’re all used to at this point, there’s 0 need for alarm.
-> END

=== PublicUnrest_Highest ===
It’s as if they don’t care about how we wake up to make our money as long as overall they turn in a profit to the top brass. It’s appalling. 
We’ve had the option to switch to all kinds of industry from industrial to water based such as hydroelectric power for a quick profit. 
But instead, they insisted that agriculture will slowly reduce as everyone switches, therefore increasing its value. 
But look at what happened to that.
-> END