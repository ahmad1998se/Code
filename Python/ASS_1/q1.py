from tkinter import  *
from tkinter import ttk

root=Tk()
root.title("“q1.py")


ttk.Label(root,text="Expression",background="black",foreground="white").grid(row=0,column=0,sticky='snew',ipadx=50,ipady=14.5)


ttk.Label(root,text="2 * 3  = ",background="gray50",foreground="white").grid(row=1,column=0,sticky='snew',ipadx=50,ipady=14.5)
ttk.Label(root,text="2 ** 3  =",background="gray25",foreground="white").grid(row=2,column=0,sticky='snew',ipadx=50,ipady=14.5)
ttk.Label(root,text="2 + 2 * 5  =",background="gray50",foreground="white").grid(row=3,column=0,sticky='snew',ipadx=50,ipady=14.5)
ttk.Label(root,text="(2 + 2) * 5  =",background="gray25",foreground="white").grid(row=4,column=0,sticky='snew',ipadx=50,ipady=14.5)
ttk.Label(root,text="-4 - -4 - -4  =",background="gray50",foreground="white").grid(row=5,column=0,sticky='snew',ipadx=50,ipady=14.5)
ttk.Label(root,text="2 ** 2 ** 0  =",background="gray25",foreground="white").grid(row=6,column=0,sticky='snew',ipadx=50,ipady=14.5)
ttk.Label(root,text="(2 ** 2) ** 0  =",background="gray50",foreground="white").grid(row=7,column=0,sticky='snew',ipadx=50,ipady=14.5)
ttk.Label(root,text="4 // 2  =",background="gray25",foreground="white").grid(row=8,column=0,sticky='snew',ipadx=50,ipady=14.5)
ttk.Label(root,text="5 // 2  =",background="gray50",foreground="white").grid(row=9,column=0,sticky='snew',ipadx=50,ipady=14.5)
ttk.Label(root,text="5 // 2.0  =",background="gray25",foreground="white").grid(row=10,column=0,sticky='snew',ipadx=50,ipady=14.5)
ttk.Label(root,text="5.5 // 2.5  =",background="gray50",foreground="white").grid(row=11,column=0,sticky='snew',ipadx=50,ipady=14.5)
ttk.Label(root,text="4 / 2  =",background="gray25",foreground="white").grid(row=12,column=0,sticky='snew',ipadx=50,ipady=14.5)
ttk.Label(root,text="5 / 2  =",background="gray50",foreground="white").grid(row=13,column=0,sticky='snew',ipadx=50,ipady=14.5)
ttk.Label(root,text="5 / 2.0  =",background="gray25",foreground="white").grid(row=14,column=0,sticky='snew',ipadx=50,ipady=14.5)
ttk.Label(root,text="5.5 / 2.5  =",background="gray50",foreground="white").grid(row=15,column=0,sticky='snew',ipadx=50,ipady=14.5)
ttk.Label(root,text="5 % 2  =",background="gray25",foreground="white").grid(row=16,column=0,sticky='snew',ipadx=50,ipady=14.5)
ttk.Label(root,text="6 % 2  =",background="gray50",foreground="white").grid(row=17,column=0,sticky='snew',ipadx=50,ipady=14.5)
ttk.Label(root,text="8 % 3  =",background="gray25",foreground="white").grid(row=18,column=0,sticky='snew',ipadx=50,ipady=14.5)
ttk.Label(root,text="6.2 % 4  =",background="gray50",foreground="white").grid(row=19,column=0,sticky='snew',ipadx=50,ipady=14.5)
ttk.Label(root,text="-5 % 4  =",background="gray25",foreground="white").grid(row=20,column=0,sticky='snew',ipadx=50,ipady=14.5)


ttk.Label(root,text="Result",background="black",foreground="white").grid(row=0,column=1,sticky='snew',ipadx=50,ipady=14.5)


ttk.Label(root,text=2 * 3,background="gray50",foreground="white").grid(row=1,column=1,sticky='snew',ipadx=50,ipady=14.5)
ttk.Label(root,text=2 ** 3,background="gray25",foreground="white").grid(row=2,column=1,sticky='snew',ipadx=50,ipady=14.5)
ttk.Label(root,text=2 + 2 * 5,background="gray50",foreground="white").grid(row=3,column=1,sticky='snew',ipadx=50,ipady=14.5)
ttk.Label(root,text=(2 + 2) * 5 ,background="gray25",foreground="white").grid(row=4,column=1,sticky='snew',ipadx=50,ipady=14.5)
ttk.Label(root,text=-4 - -4 - -4,background="gray50",foreground="white").grid(row=5,column=1,sticky='snew',ipadx=50,ipady=14.5)
ttk.Label(root,text=2 ** 2 ** 0,background="gray25",foreground="white").grid(row=6,column=1,sticky='snew',ipadx=50,ipady=14.5)
ttk.Label(root,text=(2 ** 2) ** 0,background="gray50",foreground="white").grid(row=7,column=1,sticky='snew',ipadx=50,ipady=14.5)
ttk.Label(root,text=4 // 2,background="gray25",foreground="white").grid(row=8,column=1,sticky='snew',ipadx=50,ipady=14.5)
ttk.Label(root,text=5 // 2,background="gray50",foreground="white").grid(row=9,column=1,sticky='snew',ipadx=50,ipady=14.5)
ttk.Label(root,text=5 // 2.0,background="gray25",foreground="white").grid(row=10,column=1,sticky='snew',ipadx=50,ipady=14.5)
ttk.Label(root,text=5.5 // 2.5,background="gray50",foreground="white").grid(row=11,column=1,sticky='snew',ipadx=50,ipady=14.5)
ttk.Label(root,text=4 / 2,background="gray25",foreground="white").grid(row=12,column=1,sticky='snew',ipadx=50,ipady=14.5)
ttk.Label(root,text=5 / 2,background="gray50",foreground="white").grid(row=13,column=1,sticky='snew',ipadx=50,ipady=14.5)
ttk.Label(root,text=5 / 2.0,background="gray25",foreground="white").grid(row=14,column=1,sticky='snew',ipadx=50,ipady=14.5)
ttk.Label(root,text=5.5 / 2.5,background="gray50",foreground="white").grid(row=15,column=1,sticky='snew',ipadx=50,ipady=14.5)
ttk.Label(root,text=5 % 2 ,background="gray25",foreground="white").grid(row=16,column=1,sticky='snew',ipadx=50,ipady=14.5)
ttk.Label(root,text=6 % 2,background="gray50",foreground="white").grid(row=17,column=1,sticky='snew',ipadx=50,ipady=14.5)
ttk.Label(root,text=8 % 3,background="gray25",foreground="white").grid(row=18,column=1,sticky='snew',ipadx=50,ipady=14.5)
ttk.Label(root,text=6.2 % 4 ,background="gray50",foreground="white").grid(row=19,column=1,sticky='snew',ipadx=50,ipady=14.5)
ttk.Label(root,text=-5 % 4,background="gray25",foreground="white").grid(row=20,column=1,sticky='snew',ipadx=50,ipady=14.5)






root.mainloop()