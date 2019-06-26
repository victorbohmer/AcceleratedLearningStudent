﻿# 4 More options

Continue on the app and let the user decide on which separator to use and if he/she wants to see error messages:

![49](Images/49.png)
 
In the example above the user didn’t want to see error messages.


## Extra

1. Create a *testproject* with testmethods to assert that your code don't have bugs. Test the following methods: CreateArrayOfPeople, CleanUpArray, PeopleArrayIsValid

2. When the list (in green) is displayed, instead of quitting to program: let the user decide if he/she want do enter a list again or quit the program

3. Create a file *Yes.txt*, that contains “yes” in diffent languages: “yes,ja,si,oui”. Allow the user to enter any one the words as “yes”. Create a file *No.txt* that works the same way.

4. Stop using Yes.txt and No.txt. Create a XML-file *settings.xml* that contains default values (for the two first questions) and “yes” and “no” in different languages.

5. Create a JSON-file *settings.json*, that works the same way as the XML-file.

## Hint

To solve this, create two more methods:

	char AskUserForSeparator()
	bool AskUserForErrorMessage()

Check if a string is null och whitespace:

    myString.IsNullOrWhiteSpace(...)


Try to parse a string to a character:

    char.TryParse(...)
