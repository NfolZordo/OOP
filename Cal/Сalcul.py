from tkinter import *


class Test():
    def __init__(self):

        self.lineWrite = 0

        self.root = Tk()
        self.root.title("Calcul")
        
        self.lineWrite = 1
        self.sign = 0
        self.entry1val = []
        self.textEntry1Do = StringVar()
        self.textEntry1Do.set(self.entry1val)
        self.entry2val = []
        self.textEntry2Do = StringVar()
        self.textEntry2Do.set(self.entry2val)
        self.entry3val = []
        self.textEntry3Do = StringVar()
        self.textEntry3Do.set(self.entry3val)

        self.language_entry1 = Entry(width=35,textvariable=self.textEntry1Do, state="readonly")
        self.language_entry1.grid(row=0, column=1, columnspan=3,  padx=10, pady=10)
        self.language_entry3 = Entry(width=35,textvariable=self.textEntry3Do, state="readonly")
        self.language_entry3.grid(row=2, column=1, columnspan=3,  padx=10, pady=10)

        self.button1 = Button(text="1", command=self.clicButton1, width=8).grid(row=5, column=1, padx=5, pady=5)
        self.button2 = Button(text="2", command=self.clicButton2, width=8).grid(row=5, column=2, padx=5, pady=5)
        self.button3 = Button(text="3", command=self.clicButton3, width=8).grid(row=5, column=3, padx=5, pady=5)
        self.button4 = Button(text="4", command=self.clicButton4, width=8).grid(row=4, column=1, padx=5, pady=5)
        self.button5 = Button(text="5", command=self.clicButton5, width=8).grid(row=4, column=2, padx=5, pady=5)
        self.button6 = Button(text="6", command=self.clicButton6, width=8).grid(row=4, column=3, padx=5, pady=5)
        self.button7 = Button(text="7", command=self.clicButton7, width=8).grid(row=3, column=1, padx=5, pady=5)
        self.button8 = Button(text="8", command=self.clicButton8, width=8).grid(row=3, column=2, padx=5, pady=5)
        self.button9 = Button(text="9", command=self.clicButton9, width=8).grid(row=3, column=3, padx=5, pady=5)
        self.button0 = Button(text="0", command=self.clicButton0, width=8).grid(row=6, column=2, padx=5, pady=5)
        self.buttonRa = Button(text="/", command=self.clicButtonRa, width=8).grid(row=4, column=4, padx=5, pady=5)
        self.buttonDo = Button(text="*", command=self.clicButtonDo, width=8).grid(row=5, column=4, padx=5, pady=5)
        self.buttonMi = Button(text="-", command=self.clicButtonMi, width=8).grid(row=6, column=4, padx=5, pady=5)
        self.buttonSum = Button(text="+", command=self.clicButtonSum, width=8).grid(row=6, column=3, padx=5, pady=5)
        self.buttonEnd = Button(text="=", width=8, command=self.clicButtonEnd).grid(row=2, column=4, padx=5, pady=5)
        self.buttonPoint = Button(text=",", width=8, command=self.clicButtonPoint).grid(row=6, column=1, padx=5, pady=5)
        self.buttonAc = Button(text="AC", command=self.clicButtonAc, width=8).grid(row=3, column=4, padx=5, pady=5)

        self.textLablDo = StringVar()
        self.textLablDo.set("")
        self.labelDo = Label(textvariable=self.textLablDo).grid(row=0, column=4, padx=5, pady=5)


        self.root.mainloop()



    def clicButton1(self):
        self.entry1val.append("1")
        self.textEntry1Do.set(self.entry1val)

    def clicButton2(self):
        self.entry1val.append("2")
        self.textEntry1Do.set(self.entry1val)

    def clicButton3(self):
        self.entry1val.append("3")
        self.textEntry1Do.set(self.entry1val)

    def clicButton4(self):
        self.entry1val.append("4")
        self.textEntry1Do.set(self.entry1val)

    def clicButton5(self):
        self.entry1val.append("5")
        self.textEntry1Do.set(self.entry1val)

    def clicButton6(self):
        self.entry1val.append("6")
        self.textEntry1Do.set(self.entry1val)

    def clicButton7(self):
        self.entry1val.append("7")
        self.textEntry1Do.set(self.entry1val)

    def clicButton8(self):
        self.entry1val.append("8")
        self.textEntry1Do.set(self.entry1val)

    def clicButton9(self):
        self.entry1val.append("9")
        self.textEntry1Do.set(self.entry1val)

    def clicButton0(self):
        self.entry1val.append("0")
        self.textEntry1Do.set(self.entry1val)


    def result(self, linRid1, f1, duit):
        if (self.duit == 1):
            if ("." in self.linRid1):
                self.f1 =  self.f1*float(self.linRid1)    
            else:
                self.f1 =  self.f1*int(self.linRid1)
        if (self.duit == 2):
            if ("." in self.linRid1):
                self.f1 =  self.f1/float(self.linRid1)    
            else:
                self.f1 =  self.f1/int(self.linRid1)
        if (self.duit == 3):
            if ("." in self.linRid1):
                self.f1 =  self.f1+float(self.linRid1)    
            else:
                self.f1 =  self.f1+int(self.linRid1)
        if (self.duit == 4):
            if ("." in self.linRid1):
                self.f1 =  self.f1-float(self.linRid1)    
            else:
                self.f1 =  self.f1-int(self.linRid1)
        return (self.f1)


    def clicButtonRa(self):
        
        if ( self.sign != 1):
            self.linRid1 = ''.join(self.entry1val)
            self.entry1val = []
            self.textEntry1Do.set(self.entry1val)
            if ("." in self.linRid1):
                self.f1 = float(self.linRid1)    
            else:
                self.f1 = int(self.linRid1)
            self.sign = 1
        else:
            self.linRid1 = ''.join(self.entry1val)
            self.entry1val = []
            self.textEntry1Do.set(self.entry1val)
            self.result(self.linRid1, self.f1, self.duit)
        self.duit = 2
        self.textEntry3Do.set(self.f1)




    def clicButtonDo(self):
        if ( self.sign != 1):
            self.linRid1 = ''.join(self.entry1val)
            self.entry1val = []
            self.textEntry1Do.set(self.entry1val)
            if ("." in self.linRid1):
                self.f1 = float(self.linRid1)    
            else:
                self.f1 = int(self.linRid1)
            self.sign = 1
        else:
            self.linRid1 = ''.join(self.entry1val)
            self.entry1val = []
            self.textEntry1Do.set(self.entry1val)
            self.result(self.linRid1, self.f1, self.duit)      
        self.duit = 1
        self.textEntry3Do.set(self.f1)
    def clicButtonMi(self):
        if ( self.sign != 1):
            self.linRid1 = ''.join(self.entry1val)
            self.entry1val = []
            self.textEntry1Do.set(self.entry1val)
            if ("." in self.linRid1):
                self.f1 = float(self.linRid1)    
            else:
                self.f1 = int(self.linRid1)
            self.sign = 1
        else:
            self.linRid1 = ''.join(self.entry1val)
            self.entry1val = []
            self.textEntry1Do.set(self.entry1val)
            self.result(self.linRid1, self.f1, self.duit)
        self.duit = 4
        self.textEntry3Do.set(self.f1)
    def clicButtonSum(self):
        if ( self.sign != 1):
            self.linRid1 = ''.join(self.entry1val)
            self.entry1val = []
            self.textEntry1Do.set(self.entry1val)
            if ("." in self.linRid1):
                self.f1 = float(self.linRid1)    
            else:
                self.f1 = int(self.linRid1)
            self.sign = 1
        else:
            self.linRid1 = ''.join(self.entry1val)
            self.entry1val = []
            self.textEntry1Do.set(self.entry1val)
            self.result(self.linRid1, self.f1, self.duit)
        self.duit = 3
        self.textEntry3Do.set(self.f1)

       

    def clicButtonEnd(self):
        
        self.linRid1 = ''.join(self.entry1val)
        self.linRid2 = ''.join(self.entry2val)
        self.linRid3 = 0
        self.f1 = self.result(self.linRid1, self.f1, self.duit)

        self.textEntry3Do.set(self.f1)


    def clicButtonPoint(self):
 
        self.entry1val.append(".")
        self.textEntry1Do.set(self.entry1val)

    def clicButtonAc(self):
        self.entry1val = []
        self.textEntry1Do.set(self.entry1val)
        self.entry3val = []
        self.textEntry3Do.set(self.entry3val)
        self.textLablDo.set("")  
        self.f1 = 0
        self.duit = 0
        self.sign = 0




app=Test()