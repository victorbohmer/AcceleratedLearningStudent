# 3 Add validation

Continue on the previous app, but add validation:

![42](Images/42.png)

## Extra

1. In the example above “7,Apple” didn’t work. One other solution might be that the product with id=7 will get a new name: Apple. Ask the user first how he/she want the program to work in this situations.

## Hint

Create a method BuildProductDictionary:

    private Dictionary<int, string> BuildProductDictionary()
    {
        ...

        while (true)
        {
            ...
            // Use "break" if user just hit the key "return"
            // Use "continue" if user entered a wrong input
            ...
        }
    }