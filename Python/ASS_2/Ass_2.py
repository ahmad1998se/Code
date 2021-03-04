import os
import re
from collections import Counter
from colorama import Fore, Back
#Ahmad Hani Al_Mahameed(122153)
'''Read File And Filter it With Regx'''
try:
    
    while(True):
        print(Fore.YELLOW+"0: to read a text file and print its total number of characters\n"
              "1: to count # of all letters in the file\n"
              "2: to count # of unique characters in the file\n"
              "3: to count # occurrences / frequency for all characters in the file\n"
              "4: to count # occurrences / frequency of all lower case letters in the file (‘a-z’)\n"
              "5: to count # occurrences / frequency of all upper case letters in the file (‘A-Z’)\n"
              "6: to count # occurrences / frequency of all lower case vowels in the file (‘aeiou’)"
              "7: to count # occurrences / frequency of all upper case vowels in the file (‘AEIOU’)\n"
              "8: to count # occurrences / frequency of all digits in the file (‘0123456789’)\n"
              "9: to Exit\n")
        #if not exist create one

        #if os.path.exists(fName): Can Use It To prevent The Exception
        read=open("Test.txt","r+")
        select=int(input("select one of the followings :"))
        if(select==0):
            #Will Read The \n
            data = read.read()
            number_of_character = len(data)
            print(Fore.BLUE+"You Select 0 option And The total number of characters is : "+Fore.RED+"{}".format(number_of_character))
        elif(select==1):
            data = read.read()
            letters=re.findall(r"[A-z]",data)
            print(Fore.BLUE+"You Select 1 option And The total number of all letters in the files is : "+Fore.RED+"{}".format(len(letters)))
        elif (select == 2):
            data = read.read()
            unique_characters = set(re.findall(r".", data))
            print(Fore.BLUE+"The total number of unique characters  in the files is : "+Fore.RED+"{}".format(len(unique_characters)))
        elif(select == 3):
            data = read.read()
            frequency_characters=Counter(data)
            print(Fore.BLUE+"The total number of occurrences / frequency for all characters in the file : "+Fore.RED+"{}".format(frequency_characters))
        elif (select == 4):
            data = read.read()
            frequency_characters = re.findall(r"[a-z]", data)
            print(Fore.BLUE+"The total number of occurrences / frequency of all lower case letters in the file (‘a-z’) : "+Fore.RED+"{}".format(Counter(frequency_characters)))
        elif (select == 5):
            data = read.read()
            frequency_characters = re.findall(r"[A-z]", data)
            print("The total number of occurrences / frequency of all upper case letters in the file (‘A-Z’) : "+Fore.RED+"{}".format(Counter(frequency_characters)))
        elif (select == 6):
            data = read.read()
            frequency_characters = re.findall(r"[aeiou]", data)
            print(Fore.BLUE+"The total number of occurrences / frequency of all lower case vowels in the file (‘aeiou’) : "+Fore.RED+"{}".format(Counter(frequency_characters)))
        elif (select == 7):
            data = read.read()
            frequency_characters = re.findall(r"[AEIOU]", data)
            print(Fore.BLUE+"The total number of occurrences / frequency of all upper case vowels in the file (‘AEIOU’) : "+Fore.RED+"{}".format(Counter(frequency_characters)))
        elif (select == 8):
            data = read.read()
            frequency_characters = re.findall(r"\d", data)
            print(Fore.BLUE+"The total number of occurrences / frequency of all digits in the file (‘0123456789’) : "+Fore.RED+"{}".format(Counter(frequency_characters)))
        elif (select == 9):
            print(Fore.RED+"Thanks and Good Bye")
            break

except Exception as e:
    # Can Handle And Separate Exception Based On Message That Will Out
    print(e.__str__())

except IOError:
    print(Fore.RED+"The File Not Exist \n Change The Name OR Dir Of Os To Read ")
    # Can Here Create The File That Does not exist
finally:
    read.close()