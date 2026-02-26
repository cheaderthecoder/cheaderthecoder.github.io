# 5-Letter-Words
![GitHub code size in bytes](https://img.shields.io/github/languages/code-size/darkermango/5-Letter-words)
![GitHub top language](https://img.shields.io/github/languages/top/darkermango/5-Letter-words)
![LICENSE](https://img.shields.io/github/license/darkermango/5-Letter-words)

A collection of five-letter English words, easily consumable via a simple api over at [words.txt](https://darkermango.github.io/5-Letter-words/words.txt), and [words.json](https://darkermango.github.io/5-Letter-words/words.json). Available in both JSON and txt. With an extra C# script to convert txt to json thrown in 😉.


## Table of Contents
- [Usage](#Usage)
- [endpoints](#Endpoints)
- [Downloads](#Download)
- [Examples](#Examples)
- [Script](#Script)
- [Acknowledgements](#Acknowledgements)
- [License](#License)


## Usage
You have 4 options oo how you can use this list in your project, heres a table to elaborate what I mean:
| File Type | API                                                                           | Download                                                                                  |
|-----------|-------------------------------------------------------------------------------|-------------------------------------------------------------------------------------------|
| JSON      | [consume words.json](https://darkermango.github.io/5-Letter-words/words.json) | [Download words.json](https://github.com/darkermango/5-Letter-words/blob/main/words.json) |
| txt       | [consume words.txt](https://darkermango.github.io/5-Letter-words/words.txt)  | [Download words.txt](https://github.com/darkermango/5-Letter-words/blob/main/words.txt)  |


> [!Note]
>  ### Use Cases
>**API**: consumes from the api.
>**Donwload** download the file locally.


### Examples
a list of examples of using the word list in your program

#### Python 
Fetching the JSON Data from the endpoint
```python
import requests

url = "https://darkermango.github.io/5-Letter-words/words.json"
response = requests.get(url)
words = response.json()

print(words[:10])  # Print the first 10 words as an example
```

#### c#
Reading from the TXT file locally

```c#
using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Path to the local file containing the 5-letter words
        string filePath = "path/to/your/words.txt";

        // Read all lines from the file into a string array
        string[] words = File.ReadAllLines(filePath);

        // Example: Print the words
        foreach (var word in words)
        {
            Console.WriteLine(wordList[i]);
        }

      Console.ReadKey();
    }
}
```

### JavaScript
Fetching the TXT Data from the endpoint

```js
// URL of the TXT file
const url = 'https://darkermango.github.io/5-Letter-words/words.txt';

// Fetch the TXT file
fetch(url)
  .then(response => {
    // Check if the response is successful
    if (!response.ok) {
      throw new Error('Status Code: ' + response.statusText);
    }
    return response.text(); // Return the text content
  })
  .then(data => {
    // Split the text data by new lines into an array of words
    const words = data.split('\n').map(word => word.trim());

    // Example: Log the first 10 words
    console.log('First 10 words:', words.slice(0, 10));

    // Log all words (optional)
    // words.forEach(word => console.log(word));
  })
  .catch(error => {
    // Handle errors
    console.error('error:', error);
  });
```


## Script
This script converts a list of words from a text file into a JSON file format. It fetches a text file containing a list of five-letter words from a specified URL, processes the content, and saves it as a JSON file.


---


## Acknowledgements
 - [Original Repo](https://github.com/charlesreid1/five-letter-words)
 - [Original TXT file](https://github.com/charlesreid1/five-letter-words/blob/master/sgb-words.txt)
 - [Readme.so](https://readme.so/editor)


## License
This project is licensed under the [MIT License](https://opensource.org/license/mit)
License. See the <a href="https://github.com/darkermango/5-Letter-words/blob/main/LICENSE" target="_blank">LICENSE</a> file for
details

