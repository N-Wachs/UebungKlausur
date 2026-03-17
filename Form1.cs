namespace WinFormsApp69;

public partial class Form1 : Form
{
    // Felder
    private Controller _verwalter;

    // Accessoren/Modifikatoren
    private Controller Verwalter { get => _verwalter; set => _verwalter = value; }

    // Konstruktoren
    public Form1()
    {
        InitializeComponent();
        _verwalter = new Controller();
    }

    // Konstruktor mit Controller damit wir die Funkrionen des Controllers verwenden können.
    public Form1(Controller verwalter)
    {
        InitializeComponent();
        _verwalter = verwalter;

        // Laden der alten Eingabe übder den Controller.
        label_Begrüßung.Text = "Hallo " + _verwalter.Laden();
    }

    // Wird aufgerufen, wenn der Button "Bestätigung" geklickt wird.
    private void button_Bestätigung_Click(object sender, EventArgs e)
    {
        // Setzen des Texts im Label auf "Hallo " gefolgt von der Eingabe aus dem TextBox.
        string eingabe = textBox_Eingabe.Text;
        label_Begrüßung.Text = "Hallo " + eingabe;

        // Das Speichern der Eingabe in der Controller-Klasse erfolgt, um die Trennung von Logik und Benutzeroberfläche zu gewährleisten.
        Verwalter.Speichern(eingabe);
    }
}
