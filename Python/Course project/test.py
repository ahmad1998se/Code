import urllib.request as web
import matplotlib.pyplot as plt
from collections import Counter
from colorama import Fore, Back
import re

page=web.urlopen("http://www.just.edu.jo")
data=str((page.read()).lower())

frequency_characters = re.findall(r"[aeiou]", data)
print(
      Fore.BLUE + "The total number of occurrences / frequency of all lower case vowels in the file (‘aeiou’) : " + Fore.RED + "{}".format(
      Counter(frequency_characters)))





page.close()

