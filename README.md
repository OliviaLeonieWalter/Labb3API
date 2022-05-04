# Labb3API
A schoolproject - A hobbytracker API

Uppgift 1 - Hämta alla personer i systemet

Anropsmetod: GET
AnropsUrl: https://localhost:44371/api/hobbytracker/users
________________________________________________________________________________________

Uppgift 2 - Hämta alla intressen som är kopplade till en specifik person

Anropsmetod: GET
AnropsUrl: https://localhost:44371/api/hobbytracker/hobbies/1   <-- Där ettan är userid.
________________________________________________________________________________________

Uppgift 3 - Hämta alla länkar som är kopplade till en specifik person

Anropsmetod: GET
AnropsUrl: https://localhost:44371/api/hobbytracker/links/2 <-- Där tvåan är userid.
________________________________________________________________________________________
Uppgift 4 - Koppla en person till ett nytt intresse

Anropsmetod: POST
AnropsUrl: https://localhost:44371/api/hobbytracker/addhobby/3 <-- Där trean är userid
Raw-Jsontext:
			 {
				"hobbyTitle": "Foraging",
				"hobbyDescription": "Foraging is searching for wild food resources like plants and mushrooms"
			 }
________________________________________________________________________________________
Uppgift 5 - Lägga in nya länkar för en specifik person och ett specifikt intresse

Anropsmetod: POST
AnropsUrl: https://localhost:44371/api/hobbytracker/addlinks/userid/3/hobbyid/8 <-- där trean är userid och åttan är hobbyid
Raw-Jsontext:
			{
				"linkUrl": "https://www.scandinaviastandard.com/how-to-forage-in-the-swedish-forest/",
				"linkDescription": "A Website that shows you what you can forage in scandinavia and sweden."
			}
________________________________________________________________________________________
