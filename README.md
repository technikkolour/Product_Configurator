# Raft Configurator

## Description
This was the first project I completed as part of the Mastered Bootcamp and the main requirements were the creation of a product configurator which allowed the user to rotate an object and modify its appearance.


## itch.io Link
https://technikkolour.itch.io/raft-configurator


## Design
This project is meant to act as a raft designer in the context of a raft racing game. The player would be able to compete against others and win a variety of monetary prizes which could then be used to further improve their raft. Because of this, there is a total price displayed in the top right corner that is computed depending on the design elements chosen by the player.


## Implementation
An array is used to store the prices of the selected raft base, sail and oar. Those values are used when deciding which components to spawn and the total price of the chosen raft. When the player changes their selection, the previous components are destroyed from the scene. In the case of the raft base, however, it does not get destroyed, but has its mesh and location changed.
<p align="center">
  <img src="https://github.com/technikkolour/Arkanoid_Clone/assets/60484019/4130c79c-ca86-4397-bde2-debf7af07992">
</p>

The colour of the raft can be changed with the slider at the top of the menu. When the value is changed, the following method is called:
<p align="center">
  <img src="https://github.com/technikkolour/Arkanoid_Clone/assets/60484019/65c41407-420b-4b7a-8ab4-eaaf47728862">
</p>

While, at first, my intention was to use the mouse location in order to rotate the object, I found that there was an offset to the location that made the raft rotate in unexpected directions. In order to resolve those issues I decided to have the camera rotate around the raft using the A and D keys, according to the following method:
<p align="center">
  <img src="https://github.com/technikkolour/Arkanoid_Clone/assets/60484019/3adb60ad-4175-4e61-b072-d817c8eb48c5">
</p>


## Assets
The raft bases, the oars and the sails were modelled by me in Blender.
