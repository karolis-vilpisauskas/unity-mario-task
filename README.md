# Unity Mario Task

*By Karolis Vilpisauskas*

## Tasks

---

### 1. Fix the errors in the Console window

I instantly tackled this one when I first opened the project. It wasn't particularly difficult and I managed to find the force crash and remove it as well as fix all the issues in the console quickly.

### 2. Finish the Level

By using the tile pallet I fixed all the missing pieces of the map as well as added some sprites from the spritesheets in order to make everything look more complete. I made sure that the brick blocks were destroyed after the animation is done by simply editing the `DestroyBricks` function in `Brick.cs`. All I did in the script is added a call to the `Destroy` function with the cloned `GameObject` attached.

### 3. Create the Hidden Block

To tackle this task I first created a `public bool` in the `QuestionBlock.cs` script called `isInvisible`. This allowed me to add a state to the _QuestionBlock Animator Controller_ that would make the block invisible if `isInvisible` is set to `true`. After that I connected the states and the main functionality was done. The I added the `Platform Effector 2D` component which allowed me to add block collision only from below as well as making the collision available on all sides once the block has been hit. All this additional functionality was added to the `OnCollisionEnter2D` function of `QuestionBlock.cs`.

### 4. Make the Goal Pole animation using Timeline for the core parts

This was the most time consuming part of the project. I started working on this task by creating 2 seperate timelines, one for when Mario is powered up and one for when he is not. Then I added all the required animations including sprite changes, sprite flips and position changes. To trigger this timeline I created a script called `EndingController.cs`. This allowed me to trigger the timeline once Mario grabbed the pole and disable user inputs. In order for Mario to slide down the pole to a certain level once he grabs it at a certain level I wrote the `SetOffset` function. All this does is takes the timeline track in which Mario's position is being transformed and sets the offset values to the ones Mario had when he collided with the pole. I then added the Fireworks and Castle Flag animations to the end timeline. 

### 5. Create the UI of the game and arrange it according to the image

Using the `ScoreManager.cs` I created 3 displays: `CoinDisplay.cs`, `ScoreDisplay.cs`, `TimeDisplay.cs`. These displays are used to compute the values for usage in the UI. I then used those displays to create 3 text objects as well as the world text and put them inside a UI canvas that only covers the camera. I added an additional font for the text in order to achieve the true NES Mario UI.

---

All in all I believe the task is great. It truly tests a persons knowledge about Unity and it's functions. I enjoyed working on it and am mostly happy about how this task made me take a more in-depth look into Unity. Looking forward to learning more and working with Unity in the future!
