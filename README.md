# EmeraldTester
VR game where players constantly forge new and unique weapon for each unique enemy they encounter

- Once a weapon has been used, it immediately brakes
- The quality of the weapon is dependent on the forging process
- Players make weapons by moving their hands away from each other in VR
  - To make a blade, players must form a curve with their hand while remaining steady, and at a constant speed
  - to make a spear, players must form a line while moving slowly at the start, quickly at the end
  - to make a hammer, players must form a line while moving quickly at the start, slowly at the end

The Philosophy behind the design
- This design is my attempt to overcome some of the issues of feedback in melee VR titles, or rather, the lack of feedback.
  - In many VR titles where you wield a melee weapon, swinging it against a enemy often feels awkward due to the lack of physical feedback when the weapon makes contact with the enemy. And there's this dissonance between the player's real life hands and the weapon in VR, when the weapon has to collide with in game objects. This also makes it difficult to prevent players from rapidly swinging the weapon back and forth in order to register repeated hits.
  - By making the weapons break upon each use, not only does it further promote the core game mechanic of "constantly forging new weapons", it also provides visual feedback that is congruent with a player's physical motion.
  - it now "makes" sense that players can swing pass their enemies without feeling physical feedback from the hits, since the weapon broke.
  - This also prevents players from swing their weapons back and forth to register multiple hits.
- Another issue I wanted to overcome with this design is small VR interactions.
  - Although VR controls are rather intunitive by nature, trying to make player perform small VR interactions close to their body is awkward.
  - The core gameplay is designed around large hand gestures and swings, rather than small interactions that takes place close to the player's chest.


Techniques applied in this project:
- Procedural mesh generation
  - For the weapon forging process
- Procedural animation
  - For the dynamic enemy reaction
- Motion statistical analysis
  - For analyzing unique hand gestures to track for events

  
