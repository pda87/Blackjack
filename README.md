<h1>Blackjack</h1>
<h2>A Windows Form application written in C# which simulates a game of the card game "Blackjack".</h2>
<pre>
 ________  ___       ________  ________  ___  __          ___  ________  ________  ___  __       
|\   __  \|\  \     |\   __  \|\   ____\|\  \|\  \       |\  \|\   __  \|\   ____\|\  \|\  \     
\ \  \|\ /\ \  \    \ \  \|\  \ \  \___|\ \  \/  /|_     \ \  \ \  \|\  \ \  \___|\ \  \/  /|_   
 \ \   __  \ \  \    \ \   __  \ \  \    \ \   ___  \  __ \ \  \ \   __  \ \  \    \ \   ___  \  
  \ \  \|\  \ \  \____\ \  \ \  \ \  \____\ \  \\ \  \|\  \\_\  \ \  \ \  \ \  \____\ \  \\ \  \ 
   \ \_______\ \_______\ \__\ \__\ \_______\ \__\\ \__\ \________\ \__\ \__\ \_______\ \__\\ \__\
    \|_______|\|_______|\|__|\|__|\|_______|\|__| \|__|\|________|\|__|\|__|\|_______|\|__| \|__|

</pre>
Ascii art from <a href="http://patorjk.com/software/taag/">here</a>.

Thanks to the following site for the images of the playing cards:
<a href="http://www.jfitz.com/cards/" target="_blank">jfitz.com/cards/</a>

I created a <code>Card</code> class to hold information about the cards. At the start of the game, there are 3 cards turned face down. When the "Deal" button is clicked, 2 random cards are selected for the initial part of the hand. A card is added to the hand each time the "Hit Me" button is clicked. The sum of the cards in the hand is displayed at all times, but once the value exceeds 21, the game is over and must be reset:

<img src="https://github.com/pda87/Blackjack/blob/master/Blackjack/images/Blackjack.PNG" alt ="Blackjack">
