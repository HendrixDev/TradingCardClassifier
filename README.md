# TradingCardClassifier

My first attempt at configuring, training, and implementing a machine learning model using ML.NET.

This model is currently trained on 4 kinds of unique trading cards - Pokemon, Pokemon (energy), Pokemon (trainer), and Magic.
I plan to train it on other kinds of trading cards in the future. 

I integrated the model into a web application so a user can upload an image from their computer.
The image is then copied to the Memory Stream and converted to a byte array.
The byte array is passed to the prediction engine, and the prediction result (PredictedLabel) is then shown on screen as well as the image that was uploaded.

Here are some example photos with the predictions at the top:


![pokemon energy](https://github.com/HendrixDev/TradingCardClassifier/assets/46378088/a412ddc0-7388-4c51-8295-b8a57931acc5)
![pokemon trainer](https://github.com/HendrixDev/TradingCardClassifier/assets/46378088/653d7630-0171-4dc3-b47c-f7a33bb5c759)
![pokemon](https://github.com/HendrixDev/TradingCardClassifier/assets/46378088/0e86e3df-ef43-452e-a135-c73d42820cf0)
![magic](https://github.com/HendrixDev/TradingCardClassifier/assets/46378088/e34d0d43-fc14-4e73-8994-fec92f9bddf7)
