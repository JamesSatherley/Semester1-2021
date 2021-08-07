(:question 1:)
doc('countries.xml')/countries/country[@name = "Mongolia"] 

(:question 2:)
for $a in doc('countries.xml')/countries/country
where $a/@name = $a/city/name
return data($a/@name)

(:question 3:)
avg(doc('countries.xml')/countries/country[language = "Russian"]/@population)

(:question 4 Couldn't get to work properly:)
for $a in doc('countries.xml')/countries/country
where $a/language = "German" and xs:float($a/language/@percentage) > 49
return data($a/@name)

(:question 5:)
let $a := doc('countries.xml')/countries/country/@population
return max($a)