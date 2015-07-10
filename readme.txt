First of all: LICENSE.
Actually, there’s no license at all. 
Use this code any way you like: private, commercial, for fun or profit, for good or evil. 
But! At your own risk. No warranty or safety guaranteed. 
You can modify or redistribute it freely and widely without any limitations. 
I will be thankful to you if you keep my credentials at the top of the class, but I do not insist. 
If this code saved you time and nerves – just treat me a beer if we ever met.

Package contents.
readme.txt – text you are reading right now.
ParameterizedOutputCacheAttribute.cs – code for ParameterizedOutputCacheAttribute
Sample\Controllers\HomeController.cs – usage sample
Sample\Web.config – output cache profile definition sample.

Purpose.
OutputCache attribute is very useful to manage output cache. 
It has a bug (or maybe feature) that you have to define varyByParam collection with attribute. 
Those defined at web.config are ignored. So this code fixes the issue.

Alexander Kouznetsov
www.unconnected.info / inbox@unconnected.info
Saint-Petersburg. Russia.
2015-07-10
