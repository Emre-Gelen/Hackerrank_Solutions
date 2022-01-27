SELECT Name FROM Students 
	WHERE Marks > 75 
	ORDER by SUBSTRING(name,len(name)-2,3) ASC,ID