Начална документация на проекта



Линк към файла със задачите по проекта и дневното разпределение на задачите -->
https://docs.google.com/spreadsheets/d/1jEjpXqO_bBLwI2oTzR-TvraXGSYFcWf5cejCjU_jrio/edit#gid=1799769742

1.  Лого на екипа
 
2.  Меню
- Бутон „Play” -  генерира ново ниво

- Бутон „Upgrades“ – отваря сцената с подобренията

- Бутон “Free coins” – пуска нова реклама и след приключването ѝ ти дава 10 монети

- Индикатор за броя монети в горния десен ъгъл – променя се след закупуване на подобрение или гледане на реклама

3. Ниво
а) Герой
- Прилича на скелет
- Автоматично върви напред
- Може да скача
- Може да се самоубива, при което оставя малък череп на който после може да скочи и бива изпратен в началото на нивото
- Героят може да се самоубива, за да остави трупа си и се “възражда” в началото на играта

б) Терен
                                    - Генериран на случаен принцип с различна дължина, която влияе и на времетраенето на нивото

в) Хронометър
			- Започва да тече в началото на играта
			- При изтичане на времето, играчът автоматично губи и преминава към менюто

г)  Препятствия 
- При докосване на препятствие, героят автоматично се самоубива  
      
4. Ъпгрейди
	а) Ъпгрейд за време
			- Трае една игра
			- Струва 10 монети
			- Увеличава времето, което имаш в следващата игра с 20%

5. Реклами
		- Дават ти 10 монети за изгледана реклама







































Ден 1

1.	UI: Неработещи бутони в менюто и оправяне на рекламите – 

-	Проекта се разработва на нова версия на Unity и заради това част от кода трябваше да се пренапише. 
-	Оправени са рекламите и функционалността на бутоните в менюто 


2.	Оправяне на физиките – 

-	Героят може да скача постоянно и за това трябваше да се добави време между два скока, в което не може да се скача.


3.	Определяне повърхности по които може да скача – 

-	Героят може да скача и по вертикални повърхности и за това променихме кода така, че да може да се скача само върху повърхности с определени тагове.


4.	Камера – 

-	Преди камерата не можеше да се придвижва по Y оста, защото имаше бъг със скока и героят можеше да излети в космоса. Сега няма такъв бъг и камерата може да се движи свободно с героя.


5.	Оправяне на генерацията на терена – 

-	Когато отделните парчета на терена се генерираха оставаше място между тях и си личеше, че са отделни парчета. Всички парчета трябваше да оразмерят според първото.






6.	Upgrades: Разделяне на ъпгрейда за време на части – 

-	До момента имаше подобрение, което ти дава с 20 процента повече време на ниво.  
-	Направихме подобрението различно и вече можеш да купуваш между 5 и 20 процента повече време на всяко ниво.



7.	Добавяне на брояч за самоубийство – 

-	До момента играчът можеше да се самоубива постоянно.
-	Сега има фиксирано време от две секунди между всяко самоубийство, в което не можеш да се самоубиваш.

8.	Upgrades: Двоен Скок – 

-	Героят може да скача два пъти при закупено подобрение, като вторият път скока е по-малък.



