import os
import re
import urllib.request as web
from collections import Counter
from colorama import Fore, Back#download if not exist
import matplotlib.pyplot as plt#download if not exist
# Ahmad Hani Al_Mahameed(122153)
'''Read File And Filter it With Regx'''
try:

    while (True):
        print(Fore.YELLOW + "1: read the contents of that page and prints out its contents on the screen \n"
                            "2: Draw a column chart with the frequency of the characters in that webpage \n"
                            "3: Draw a column chart with the frequency of the letters in that webpage (A-Z and a-z) \n"
                            "4: Draw a column chart with the frequency of the digits in that webpage (0-9)\n"
                            "5: Draw a column chart with the frequency of the vowels in that webpage (aeiouAEIOU)\n"
                            "0: to Exit\n")
        # if not exist create one

        # if os.path.exists(fName): Can Use It To prevent The Exception

        select = input("Enter Valid Website Url : ")
        if (re.findall(r"^(http:\/\/www\.|https:\/\/www\.|http:\/\/|https:\/\/)+[a-z0-9]+([\-\.]{1}[a-z0-9]+)*\.[a-z]{2,5}(:[0-9]{1,5})?(\/.*)?$",select)):

            page=web.urlopen(select)
        else:
            continue
        select = int(input("Enter Number From The Menu : "))
        if (select == 1):
            # Will Read The \n
            data=str(page.read())
            print(Fore.BLUE + "You Select 0 option And The contents of in that webpage : " + Fore.RED + "{}".format(data))
        elif (select == 2):
            data = str(page.read())

            frequency_characters = re.findall(r"\.", data)
            print(
                Fore.BLUE + "The total number of frequency of the characters in that webpage : " + Fore.RED + "{}".format(
                    Counter(frequency_characters)))

            dic = dict(Counter(frequency_characters))
            plt.bar(dic.keys(), dic.values())
            plt.xlabel("Characters")
            plt.ylabel("Frequency")
            plt.title('My Bar Chart For characters !')
            plt.show()

        elif (select == 3):
            data = str(page.read())

            letters = re.findall(r"[a-zA-Z]", data)
            print(
                Fore.BLUE + "You Select 3 option And The total number of all letters in that webpage : " + Fore.RED + "{}".format(
                    len(letters)))
            dic = dict(Counter(letters))
            plt.bar(dic.keys(), dic.values())
            plt.xlabel("Letters")
            plt.ylabel("Frequency")
            plt.title('My Bar Chart For Letters !')
            plt.show()
        elif (select == 4):
            data = str(page.read())

            frequency_characters = re.findall(r"\d", data)
            print(
                Fore.BLUE + "The total number of occurrences / frequency of all digits in that webpage (‘0123456789’) : " + Fore.RED + "{}".format(
                    Counter(frequency_characters)))
            dic = dict(Counter(frequency_characters))
            plt.bar(dic.keys(), dic.values())
            plt.xlabel("Digits")
            plt.ylabel("Frequency")
            plt.title('My Bar Chart For Digits !')
            plt.show()

        elif (select == 5):
            data=str((page.read()).lower())

            frequency_characters = re.findall(r"[aeiou]", data)
            print(
                Fore.BLUE + "The total number of occurrences / frequency of all  of the vowels in that webpage (‘aeiou’) : " + Fore.RED + "{}".format(
                    Counter(frequency_characters)))
            dic = dict(Counter(frequency_characters))
            plt.bar(dic.keys(), dic.values())
            plt.xlabel("Vowels ")
            plt.ylabel("Frequency")
            plt.title('My Bar Chart For Vowels !')
            plt.show()

        elif (select == 0):
            print(Fore.RED + "Thanks and Good Bye")
            break

except Exception as e:
    # Can Handle And Separate Exception Based On Message That Will Out
    print("The Exception That Raised is "+e.__str__())

except IOError:
    print(Fore.RED + "The File Not Exist \n Change The Name OR Dir Of Os To Read ")
    # Can Here Create The File That Does not exist
finally:
    page.close()