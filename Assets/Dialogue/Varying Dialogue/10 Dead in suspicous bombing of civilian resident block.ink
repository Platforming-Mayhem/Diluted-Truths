INCLUDE ..\globals.ink

{gov_distrust >= 6:
    {public_unrest>= 7: -> PublicUnrest_Highest}
    -> Distrust_Highest
- else:
    -> PublicOp_Highest

}

=== Distrust_Highest ===
This is just cold-blooded murder. The worst part is I want to be able to say, There’s no way they’ll manage to worm their way out of this. It's what I want to say and think.
But in the end, everyone will forget once the backlash is gone it’s happened to many a time already.
-> END

=== PublicOp_Highest ===
This is insane. No way. The military AND government both allowed this to happen… I’m ashamed to even be related to this country right now. 
10 innocents killed for what? There doesn’t even seem to be a possible motive right now. It’s an atrocity.
-> END

=== PublicUnrest_Highest ===
This can’t go unpunished at all. If they can’t hear our screams, let them hear their own in their final moments. This country needs more than reforms. It needs a purge.
-> END
