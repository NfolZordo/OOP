//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "Unit1.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma resource "*.dfm"
TForm1 *Form1;
float a, b, f1;
int sign,duit                  ;
using namespace std;
//---------------------------------------------------------------------------
__fastcall TForm1::TForm1(TComponent* Owner)
	: TForm(Owner)
{
}


float result(){
	if(duit == 1){
	f1=f1*a;
	}
	if(duit == 2){
	f1=f1/a;
	}
	if(duit == 3){
	f1=f1+a;
	}
	if(duit == 4){
	f1=f1-a;
	}
return(0);
}


//---------------------------------------------------------------------------
void __fastcall TForm1::Button1Click(TObject *Sender)
{
	if (sign != 1)
	{
		f1=StrToFloat(Edit1->Text)   ;
		Edit1->Text = "" ;
		Edit3->Text = f1;
		sign = 1;
	}
	else{
		a=StrToFloat(Edit1->Text)   ;
		Edit1->Text = "" ;
		result();
		Edit3->Text = f1;
	}
		duit =3;
}
//---------------------------------------------------------------------------




void __fastcall TForm1::Button16Click(TObject *Sender)
{
	if (sign != 1)
	{
		f1=StrToFloat(Edit1->Text)   ;
		Edit1->Text = "" ;
		Edit3->Text = f1;
		sign = 1;
	}
	else{
		a=StrToFloat(Edit1->Text)   ;
		Edit1->Text = "" ;
		result();
		Edit3->Text = f1;
	}
			duit =4;
}
//---------------------------------------------------------------------------

void __fastcall TForm1::Button13Click(TObject *Sender)
{

	if (sign != 1)
	{
		f1=StrToFloat(Edit1->Text)   ;
		Edit1->Text = "" ;
		Edit3->Text = f1;
		sign = 1;
	}
	else{
		a=StrToFloat(Edit1->Text)   ;
		Edit1->Text = "" ;
		result();
		Edit3->Text = f1;
	}
   duit =1;
}
//---------------------------------------------------------------------------

void __fastcall TForm1::Button14Click(TObject *Sender)
{

	if (sign != 1)
	{
		f1=StrToFloat(Edit1->Text)   ;
		Edit1->Text = "" ;
		Edit3->Text = f1;
		sign = 1;
	}
	else{
		a=StrToFloat(Edit1->Text)   ;
		Edit1->Text = "" ;
		result();
		Edit3->Text = f1;
	}
  duit =2;
}
//---------------------------------------------------------------------------

void __fastcall TForm1::Button2Click(TObject *Sender)
{
	f1=0 ;
	sign=0;
	a=0;
	Edit1->Text = "" ;
	Edit3->Text = "" ;
}
//---------------------------------------------------------------------------

void __fastcall TForm1::Button3Click(TObject *Sender)
{
        a=StrToFloat(Edit1->Text)   ;
   		result();
		Edit3->Text = f1;
		Edit1->Text = "" ;
		duit = 0;
}
//---------------------------------------------------------------------------

