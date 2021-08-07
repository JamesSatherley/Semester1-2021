Hello!

I ran into quite a few issues during this, some of which I spent many hours trying to get past. I did try my best, but the program crashes quite often.
One example is when you try to run with an AI or do Human vs Human for too long. The AI runs out of moves and I have no clue why. I've spent 10+ hours
trying to fix this. Due to this 20/21 tests pass.
 
The following is copy and pasted from a comment in my recursive diagonal helper; 

//          The above code was to get rid of columns 4+ to not get false positives from the shift function
//          however this caused index errors from tranpose and showgamestate, and when fixed kept erroring
//          more so I chose to just comment it out.

This could quite possibly be the cause of the error but who knows!

I have attempted the "Make the AI smarter" however the function isn't tested due to the above reasons (or likely correct at all). I'll give a quick run 
down of my goal. If the value of the ai going there and the player going there is 100 and -100 there, then 0 is returned. I know this isn't much of a
smart change but it's something..

P.S, I tried to do as much as I could with streams... But I'm not too great with them. Thanks for reading this far and marking! :)