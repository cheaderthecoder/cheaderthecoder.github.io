# 5-Letter-Words
![GitHub code size in bytes](https://img.shields.io/github/languages/code-size/darkermango/5-Letter-words)
![GitHub top language](https://img.shields.io/github/languages/top/darkermango/5-Letter-words)
![LICENSE](https://img.shields.io/github/license/darkermango/5-Letter-words)

A collection of five-letter English words, available in both JSON and TXT format, designed for seamless integration into your project(s). This repository offers an easily accessible list of five-letter words, ideal for word games, educational resources, and various other applications, with an extra c# script to convert txt to json thrown in 😉.


## Table of Contents
- [Usage](#Usage)
- [endpoints](#Endpoints)
- [Downloads](#Download)
- [Examples](#Examples)
- [Script](#Script)
- [Acknowledgements](#Acknowledgements)
- [License](#License)


## Usage
You can easily integrate this word list into your projects by accessing either the TXT or JSON endpoints or by downloading the files locally. Below are some examples of how to read, use and sometimes fetch the word list endpoint in your application. For quick access to relevant links and further details, checkout the [resource page](https://darkermango.github.io/5-Letter-words/).

>[!Note]
> You don't have to use the endpoint(s) to get the word list; but instead you can download the words locally and access them from there. This is much faster than using the endpoints and much more reliable as the file never fails to fetch. if all you want to do is access the words, I would recommend you download the word list locally.

## Endpoints
You can access the list of words through the following endpoints:

- **TXT Format:** [words.txt](https://darkermango.github.io/5-Letter-words/words.txt)
- **JSON Format:** [words.json](https://darkermango.github.io/5-Letter-words/words.json)

## Downloads
Instead of using a endpoint you can download the files locally at:

- **TXT Format:** [Download words.txt](https://github.com/darkermango/5-Letter-words/blob/main/words.txt)
- **JSON Format:** [Download words.json](https://github.com/darkermango/5-Letter-words/blob/main/words.txt)


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
A list of Repo's/projects that helped this project in some way

 - [Original Repo](https://github.com/charlesreid1/five-letter-words)
 - [Original TXT file](https://github.com/charlesreid1/five-letter-words/blob/master/sgb-words.txt)
 - [Readme.so](https://readme.so/editor)


## License
This project is licensed under the [MIT License](https://opensource.org/license/mit)
License. See the <a href="https://github.com/darkermango/5-Letter-words/blob/main/LICENSE" target="_blank">LICENSE</a> file for
details

