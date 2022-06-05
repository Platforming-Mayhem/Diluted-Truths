INCLUDE ..\globals.ink

{gov_distrust >= 8:
    {public_unrest>= 7: -> PublicUnrest_Highest}
    -> Distrust_Highest
- else:
    -> PublicOp_Highest

}

=== Distrust_Highest ===
They think anyone will believe this garbage? There’s just no possible way they contribute 26% of our entire economy. When I know people who work harder than them only to have it dismissed because they weren’t struggling to begin with.
-> END

=== PublicOp_Highest ===
That’s amazing. Refugees aren’t respected at all and for what? They do what they need to do. Even in the horrific situations they have, they do great.
-> END

=== PublicUnrest_Highest ===
So they’ve decided to take their side on this. They’ve stuck alongside the refugees just to seem like a virtuous company, when in reality,  they’re just as big as a problem.
-> END
