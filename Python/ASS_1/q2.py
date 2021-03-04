from tkinter import  *
from tkinter import ttk

root=Tk()
root.title("“q2.py")


ttk.Label(root,text="Expression",background="black",foreground="white").grid(row=0,column=0,sticky='snew',ipadx=50,ipady=10)

ttk.Label(root,text="3 < 5  = ",background="gray50",foreground="white").grid(row=1,column=0,sticky='snew',ipadx=50,ipady=10)
ttk.Label(root,text="3 < 5 <= 10  = ",background="gray25",foreground="white").grid(row=2,column=0,sticky='snew',ipadx=50,ipady=10)
ttk.Label(root,text="10 > 5 > 2  = ",background="gray50",foreground="white").grid(row=3,column=0,sticky='snew',ipadx=50,ipady=10)
ttk.Label(root,text="10 > 5 > 7  =",background="gray25",foreground="white").grid(row=4,column=0,sticky='snew',ipadx=50,ipady=10)
ttk.Label(root,text="3 < 5 and 5 < 10  =",background="gray50",foreground="white").grid(row=5,column=0,sticky='snew',ipadx=50,ipady=10)
ttk.Label(root,text="not(True)  =",background="gray25",foreground="white").grid(row=6,column=0,sticky='snew',ipadx=50,ipady=10)
ttk.Label(root,text="not(0)  =",background="gray50",foreground="white").grid(row=7,column=0,sticky='snew',ipadx=50,ipady=10)
ttk.Label(root,text="not(True and False)  =",background="gray25",foreground="white").grid(row=8,column=0,sticky='snew',ipadx=50,ipady=10)
ttk.Label(root,text="bool(3+4) and True  =",background="gray50",foreground="white").grid(row=9,column=0,sticky='snew',ipadx=50,ipady=10)
ttk.Label(root,text="not(True)  =",background="gray25",foreground="white").grid(row=10,column=0,sticky='snew',ipadx=50,ipady=10)
ttk.Label(root,text="not(1)  =",background="gray50",foreground="white").grid(row=11,column=0,sticky='snew',ipadx=50,ipady=10)
ttk.Label(root,text="True and False  =",background="gray25",foreground="white").grid(row=12,column=0,sticky='snew',ipadx=50,ipady=10)
ttk.Label(root,text="True or False  =",background="gray50",foreground="white").grid(row=13,column=0,sticky='snew',ipadx=50,ipady=10)
ttk.Label(root,text="not True  =",background="gray25",foreground="white").grid(row=14,column=0,sticky='snew',ipadx=50,ipady=10)
ttk.Label(root,text="not not False  =",background="gray50",foreground="white").grid(row=15,column=0,sticky='snew',ipadx=50,ipady=10)
ttk.Label(root,text="not False and True  =",background="gray25",foreground="white").grid(row=16,column=0,sticky='snew',ipadx=50,ipady=10)
ttk.Label(root,text="not (False or True)  =",background="gray50",foreground="white").grid(row=17,column=0,sticky='snew',ipadx=50,ipady=10)
ttk.Label(root,text="True and False and True  =",background="gray25",foreground="white").grid(row=18,column=0,sticky='snew',ipadx=50,ipady=10)
ttk.Label(root,text="True or (False and True)  =",background="gray50",foreground="white").grid(row=19,column=0,sticky='snew',ipadx=50,ipady=10)
ttk.Label(root,text="False or ( -5 % 2 == 1)  =",background="gray25",foreground="white").grid(row=20,column=0,sticky='snew',ipadx=50,ipady=10)
ttk.Label(root,text="1 and 2   =",background="gray50",foreground="white").grid(row=21,column=0,sticky='snew',ipadx=50,ipady=10)
ttk.Label(root,text="3 > 2 > 0  =",background="gray25",foreground="white").grid(row=22,column=0,sticky='snew',ipadx=50,ipady=10)
ttk.Label(root,text="1 and 0  =",background="gray50",foreground="white").grid(row=23,column=0,sticky='snew',ipadx=50,ipady=10)
ttk.Label(root,text="bool(1 and 2)  =",background="gray25",foreground="white").grid(row=24,column=0,sticky='snew',ipadx=50,ipady=10)
ttk.Label(root,text="bool(5 and 0)  =",background="gray50",foreground="white").grid(row=25,column=0,sticky='snew',ipadx=50,ipady=10)

ttk.Label(root,text="Result",background="black",foreground="white").grid(row=0,column=1,sticky='snew',ipadx=50,ipady=10)


ttk.Label(root,text=3 < 5,background="gray50",foreground="white").grid(row=1,column=1,sticky='snew',ipadx=50,ipady=10)
ttk.Label(root,text=3 < 5 <= 10,background="gray25",foreground="white").grid(row=2,column=1,sticky='snew',ipadx=50,ipady=10)
ttk.Label(root,text=10 > 5 > 2,background="gray50",foreground="white").grid(row=3,column=1,sticky='snew',ipadx=50,ipady=10)
ttk.Label(root,text=10 > 5 > 7 ,background="gray25",foreground="white").grid(row=4,column=1,sticky='snew',ipadx=50,ipady=10)
ttk.Label(root,text=3 < 5 and 5 < 10,background="gray50",foreground="white").grid(row=5,column=1,sticky='snew',ipadx=50,ipady=10)
ttk.Label(root,text=not(True),background="gray25",foreground="white").grid(row=6,column=1,sticky='snew',ipadx=50,ipady=10)
ttk.Label(root,text=not(0),background="gray50",foreground="white").grid(row=7,column=1,sticky='snew',ipadx=50,ipady=10)
ttk.Label(root,text=not(True and False),background="gray25",foreground="white").grid(row=8,column=1,sticky='snew',ipadx=50,ipady=10)
ttk.Label(root,text=bool(3+4) and True,background="gray50",foreground="white").grid(row=9,column=1,sticky='snew',ipadx=50,ipady=10)
ttk.Label(root,text=not(True),background="gray25",foreground="white").grid(row=10,column=1,sticky='snew',ipadx=50,ipady=10)
ttk.Label(root,text=not(1),background="gray50",foreground="white").grid(row=11,column=1,sticky='snew',ipadx=50,ipady=10)
ttk.Label(root,text=True and False,background="gray25",foreground="white").grid(row=12,column=1,sticky='snew',ipadx=50,ipady=10)
ttk.Label(root,text=True or False,background="gray50",foreground="white").grid(row=13,column=1,sticky='snew',ipadx=50,ipady=10)
ttk.Label(root,text=not True,background="gray25",foreground="white").grid(row=14,column=1,sticky='snew',ipadx=50,ipady=10)
ttk.Label(root,text=not not False,background="gray50",foreground="white").grid(row=15,column=1,sticky='snew',ipadx=50,ipady=10)
ttk.Label(root,text=not False and True ,background="gray25",foreground="white").grid(row=16,column=1,sticky='snew',ipadx=50,ipady=10)
ttk.Label(root,text=not (False or True),background="gray50",foreground="white").grid(row=17,column=1,sticky='snew',ipadx=50,ipady=10)
ttk.Label(root,text=True and False and True,background="gray25",foreground="white").grid(row=18,column=1,sticky='snew',ipadx=50,ipady=10)
ttk.Label(root,text=True or (False and True),background="gray50",foreground="white").grid(row=19,column=1,sticky='snew',ipadx=50,ipady=10)
ttk.Label(root,text=-False or ( -5 % 2 == 1),background="gray25",foreground="white").grid(row=20,column=1,sticky='snew',ipadx=50,ipady=10)
ttk.Label(root,text=1 and 2 ,background="gray50",foreground="white").grid(row=21,column=1,sticky='snew',ipadx=50,ipady=10)
ttk.Label(root,text=3 > 2 > 0,background="gray25",foreground="white").grid(row=22,column=1,sticky='snew',ipadx=50,ipady=10)
ttk.Label(root,text=1 and 0,background="gray50",foreground="white").grid(row=23,column=1,sticky='snew',ipadx=50,ipady=10)
ttk.Label(root,text=bool(1 and 2),background="gray25",foreground="white").grid(row=24,column=1,sticky='snew',ipadx=50,ipady=10)

ttk.Label(root,text=bool(5 and 0),background="gray50",foreground="white").grid(row=25,column=1,sticky='snew',ipadx=50,ipady=10)



root.mainloop()