# Polaris

i made this game using Unity version 2021.3.21f1 for my A-Level Computing NEA project.

# WARNING: THIS CODE IS REALLY OLD, BARELY WORKS, AND SHOULD NOT UNDER ANY CIRCUMSTANCE BE TREATED AS BEST PRACTICE

seriously. this was my first time ever using Unity AND my first time using C# as a programming language. Before this, I only had experience with Lua and Python, so the curly brace syntax coupled with needing a semicolon after ever line was a big culture shock.

I ended up with a C in this coursework, largely because my write-up (the bit that actually gets graded) was pretty rushed...

The game is a 2.5D Shoot 'Em Up game where you control the white pill, and have to destroy the red pill(s). The game features 3 powerups that you gain access to at waves 20, 40, and 60 respectively. These are:

# Polarity Switch
This power-up is largely inspired by the "polarity switch" feature in the arcade game "Ikaruga". In that game, enemies have a polarity of either black or white, and so does your player. You deal extra damage if you shoot an enemy with the opposite polarity to your own, but you will be vulnerable to their attacks. You can absorb bullets so long as they are the same polarity as you and they charge a power up meter you can use for a homing attack...

...my game has none of these features. Due to time contraints (and not wanting to implement a polarity system on *every* enemy, I instead made the polarity switch power-up a simple 2x damage increase that lasts 10 seconds. Is it boring? Yes, but I really wanted to pass my A-Levels and so it had to be sacrificed.

# Phase Shift
This power-up is inspired by a tactical of the same name from Titanfall 2. In that game, activating the phase shift teleports you to "alternate space" for a short time, which essentially makes you invisible and invulnerable to others for a short duration, as well as doing some weird screen effects...
...my game maps this pretty closely. Upon activation, all enemies vanish and cannot hurt you, and you can just sort of move around uninterrupted. It works fine, although it doesnt do much in the way of "powering you up" as you can't shoot back. Good for a break I guess?

# Time-Warp
This power-up was inspired by the time control features added in Geometry Dash update 2.2 . In that game, you can directly control both the speed of the level's gameplay and music at any point in the level. You can make the level faster or slower...
...in my game, the powerup just slows the game down to half speed whenever you hold shift. Again, rushed feature that doesn't do much in the way of helping you. The method I used too is almost definitely not the best possible way, or even a decent way. Still, it does what it says on the tin I suppose (and who wants to speed *up* the game anyway!?)

Overall, it is a very barebones, buggy and rushed mess, but it's *my* mess and I own it! Feel free to look through as an example of what NOT to do. All the code is commented (briefly... it was done at the last minute) which should give an indication of what each line is *supposed* to do. The game runs pretty well in the Unity editor but is prone to crashing when playing in the built .exe file.

Good luck and godspeed,
Will :-)
