# Caesar-Cipher
A very simple version of Caesar Cypher encryptor/decryptor.

# What
The Caesar cipher is one of the simplest encryption schemes. The basic idea is that for every letter in your message, you shift it down the alphabet by a certain number of letters. The amount you shift is the key for the algorithm. If you are using a key of 3, A would become D, B would become E, etc. Once you get to the end of the alphabet, it wraps back around, so Z would be C. The program reads the message from the user and encrypts it, writing out the encrypted message back to the console window. The same way the program can decrypt the message. Anything besides a letter (punctuation, numbers, etc.) is passed along to the output without encrypting it. 

# How to
This program can be called only as command in terminal. Navigate to the directory with .exe file (/bin/release) and type a command with the name of assembly at the start. Example: ```MessageFromJuliusCaesar.exe encrypt -s 3 -t ДРУГМОЙЭЛЬФ!ЯШКЕБСВЁЗПТИЦЮЖНЫХЧАЩ! -r```. Where ```-s``` is steps key (the amount of letters you shift), ```-t``` is the text to encrypt/decrypt, ```-r``` is the Russian alphabet (could be also ```-e``` for English). You could add both language parameters at the end for encrypt/decrypt letters of both languages in the message.

# Features
* This version of a program works only with English and Russian alphabets. Both alphabets are represented in code as separate classes inherited from ```IAlphanet``` interface. Such solution was applied for make possible further program expansion by adding another alphabets classes and make sure that it will contain all necessary functionality while inherited from ```IALphabet```. 
* Any number of alphabets (for this version only two existing) could be passed as parameters simultaneously. In such case the program will apply the encryption/decyption for every
alphabet individually. So if you had passed as parameters English and Russian, and you have english and russian letters in your message, the encryption and decryption will work for both of them.
* The methods responsible for encryption and decryption are covered by unit tests (```Xunit```) and performance tests (```BenchmarkDotNet```). The usage of benchmarks resulted in 
solution to transform the user's prompt containing the message to encrypt/decrypt into the char array (by using ```string.ToCharArray```) before starting any manipulation of 
encryption/decryption. Mentioned solution drastically improves the performance. 
* The ```cOOnsole``` framework was integrated into this project for provide an understandable console interface for user with set of all available commands and keys. In case of prompting wrong parameters the message with usages will be displayed in console. Documentation for mentioned framework could be checked here: https://github.com/kalexii/cOOnsole/blob/main/README.md
* Another interesting feature consists in acceptability of negative keys. You can prompt a negative number as parameter to shift letters in another direction.
