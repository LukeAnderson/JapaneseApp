# Japanese App  
<br/>

[What Is It?](#What-Is-It)
<br>
[What Can You Do With It?](#What-Can-You-Do-With-It)
<br>
[How Do You Use It?](#How-Do-You-Use-It)
<br>
[What Does It Use?](#What-does-it-use)
<br>
[Possible Future Features](#Possible-Future-Features)


<br>

#### What is it
It is an application to assist those studying Japanese.

<br>

#### What Can You Do With It
Search with English or Japanese words and be provided with the word in Japanese and English.
<br>
An image of the searched term will also be shown. 

<br>

#### How Do You Use It

##### Main Feature

1. Click into the textbox with the placeholder text 'Search Words'
2. Enter in a word
3. Click the button 'Search' just right of your entered in word
4. View English, Japanese and picture
4. Click next button to the right of search to see different results.

##### Additional Features
* Choose image quality with radio buttons under image quality; choose lower quality if you have poor internet.
* Search using Flickr API for an image.
* Toggle sugegsted search on or off. Suggested search on uses Flickr API to get an image everytime you press next.
* Change font settings for English and Japanese from the MenuStrip.
<br>

#### What does it use?
[Jisho.org API](https://jisho.org/forum/54fefc1f6e73340b1f160000-is-there-any-kind-of-search-api) for searching English and Japanese
<br>
[json2csharp](http://json2csharp.com/) Created C# classes from Jisho.org's JSON
<br>
Newtonsoft.Json [Json.NET](https://www.newtonsoft.com/json) JSON framework used for deserializing Jisho.org's JSON into C# objects 
<br>
[FlickrNet API Library](https://archive.codeplex.com/?p=flickrnet) for accessing [Flickr API](https://www.flickr.com/services/api/) for images


#### Possible Future Features

* Suggested search removed from UI and put into the MenuStrip. 
* Romanization option for those who can not read the Japanese Kana 
* Part of spech information added. E.g noun,verb.
* Sentences for both English and Japanese. 
* Audio addition.
* Put in UI elements for creating a flashcard in place of suggested search. 
* Create an [Anki](https://github.com/dae/anki) flashcard with everything.
* Options for using a different search engine besides Flickr for images. E.g. Google, Bing
* General UI improvments