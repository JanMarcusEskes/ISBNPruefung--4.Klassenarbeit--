using System;
using System.Windows.Forms;

namespace ISBNPruefung
{
  public partial class ISBNPruef : Form
  {
    public ISBNPruef()
    {
      InitializeComponent();
    }

    private void btnEingabeKorrekt_Click(object sender, EventArgs e)
    {
      //Einlesen der Eingabe
      String eingabe = txtZahlenfolge.Text;
      string ISBN_Str = null;

      //Durchlaufen der einzelnen Buchstaben der Eingabe
      foreach (char buchstabe in eingabe)
      {
        //Prüfen, ob der Buchstabe eine Zahl ist
        if (buchstabe >= '0' && buchstabe <= '9')
          //Wenn er eine Zahl ist zu Ausgabestring hinzufügen
          ISBN_Str += buchstabe;
        //Wenn er kein Trennzeichen ist Fehler ausgeben
        else if (buchstabe != ' ' && buchstabe != '-')
        {
          MessageBox.Show("Sie haben ein ungültiges Zeichen eingegeben!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
          //Methode beenden
          return;
        }
      }
      //Prüfen, ob Eingabe gültig ist
      if (ISBN_Str.Length != 9)
      {
        //Ungültige Eingabe
        MessageBox.Show("Sie haben eine zu lange Zahl eingegeben!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }
      //TextBox zu Ausgabestring setzen
      txtISBN.Text = ISBN_Str;
    }

    private void btnPruefziffer_Click(object sender, EventArgs e)
    {
      //Einlesen der Eingabe
      String eingabe = txtISBN.Text;
      char[] ISBN = eingabe.ToCharArray();
      int summe = 0;

      //Jede Ziffer durchlaufen
      for (int i = 1; i < ISBN.Length + 1; i++)
      {
        //Multiplikator anwenden
        int zwischensumme = i * int.Parse(ISBN[i - 1].ToString());
        //Endsumme addieren
        summe += zwischensumme;
        //Zwischensumme zu TextBox hinzufügen
        txtAusgProdukte.Text += zwischensumme + " - ";
      }
      //Summe in TextBox ausgeben
      txtAusgSumme.Text = summe.ToString();
      //Rest errechnen
      int rest = summe % 11;

      String prüfziffer;
      //Wenn Prüfziffer == 10...
      if (rest == 10)
        //...dann Prüfziffer zu 'X'
        prüfziffer = "X";
      else
        //...sonst Prüfziffer ausgeben
        prüfziffer = rest.ToString();
       
      //TextBox zu Prüfziffer setzen
      txtAusgPruefZiffer.Text = prüfziffer;


    }

    private void btnISBNCheck_Click(object sender, EventArgs e)
    {
      //Eingabe einlesen
      String eingabe = txtISBNVollst.Text;
      string ISBN_Str = null;

      //Prüfen ob Eingabe zu kurz ist
      if (eingabe.Length < 10)
      {
        //Fehlermeldung und Methode beenden
        MessageBox.Show("Sie haben eine zu kurze Zahl eingegeben!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }
      //Prüfen ob die letzten 3 Chars die Prüfziffer sind
      if (eingabe[eingabe.Length - 1] != ']' && eingabe[eingabe.Length - 3] != '[')
      {
        //Fehlermeldung und Methode beenden
        MessageBox.Show("Sie haben keine Prüfziffer eingegeben!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }
      //Buchstaben durchlaufen
      foreach (char buchstabe in eingabe)
      {
        //Prüfen ob er eine Zahl oder die Prüfziffer 'X' ist
        if (buchstabe >= '0' && buchstabe <= '9' || buchstabe == 'X' || buchstabe == 'x')
          //Wenn er eine Zahl ist zu Ausgabestring hinzufügen
          ISBN_Str += buchstabe;
        //Wenn es keines der Zeichen ist Fehler ausgeben
        else if (buchstabe != ' ' && buchstabe != '-' && buchstabe != '[' && buchstabe != ']')
        {
          //Fehlermeldung und Methode beenden
          MessageBox.Show("Sie haben ein ungültiges Zeichen eingegeben!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
          return;
        }
      }
      //Prüfen, ob Länge gültig ist
      if (ISBN_Str.Length != 10)
      {
        //Fehlermeldung und beenden der Methode
        MessageBox.Show("Sie haben eine zu lange Zahl eingegeben!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }
      //Prüfziffer ausgeben
      txtPZ.Text = ISBN_Str[9].ToString();
      //Prüfziffer entfernen
      ISBN_Str = ISBN_Str.Remove(9, 1);
      //ISBN ausgeben
      txtISBN.Text = ISBN_Str;
    }

  }
}
