using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuturArtXTrue;

public partial class HelpPage : ContentPage
{
    public HelpPage()
    {
        InitializeComponent();
    }
    private void OnPickerSelectedIndexChanged(object sender, EventArgs e)
    {
        var selectedQuestion = faqPicker.SelectedItem as string;
        answerLabel.Text = GetAnswerForQuestion(selectedQuestion);
    }
    private string GetAnswerForQuestion(string question)
    {
        switch (question)
            {
                case "Was bietet die FuturArtX Museumsapplikation?":
                    return "FuturArtX ermöglicht es Ihnen, in die faszinierende Welt zeitgenössischer Kunst einzutauchen. Entdecken Sie Kunstwerke, geniessen Sie interaktive Führungen und vertiefen Sie Ihr Verständnis für die Künstler und ihre Werke.";
                
                case "Wo finde ich Exponate?":
                    return "Unter dem Tab Exponate finden Sie alle Exponate die es gibt aufgelistet, falls Sie spezielle und oder neue Exponate sehen möchten bietet Ihnen die Homepage die möglichkeit an, diese Exponate zu sehen.";

                case "Unterstützt FuturArtX mehrsprachige Informationen?":
                    return "Nein, die App unterstützt mehrsprachige Informationen nicht, wir arbeiten jedoch daran, dass Sie in naher Zukunft unsere Exponate auch in einer anderen Sprache begutachten können.";

                case "Kann ich Exponate in den sozialen Medien teilen?":
                    return "Ja, Sie dürfen die Exponate mit ihren freunden teilen, sie dürfen sie jedoch nicht in einem Ihrer Projekte brauchen. (nur für Eigengebrauch)";

                case "Wie erhalte ich Hilfe bei technischen Problemen?":
                    return "Bei technischen Fragen oder Problemen besuchen Sie den FAQ bereich der Applikation den Sie im Footer finden (ganz unten). Wenn Ihre Frage dadurch noch nicht beantwortet wurde dürfen sie uns eine E-Mail an 'support@kunstmuseumbern.ch' schicken.";

                case "Bietet die App Barrierefreiheitsoptionen?":
                    return "FuturArtX besitzt noch keine Barrierefreiheitsoptionen. Wenn Sie spezielle Anforderungen haben, können Sie uns unter dieser E-Mail adresse: 'bfreiheit@kunstmuseumbern.ch' kontaktieren, und wir werden versuchen Ihnen weiterzuhelfen.";

                case "Wie schützt FuturArtX meine Privatsphäre?":
                    return "Ihre Privatsphäre ist uns wichtig. Keine Ihrer Daten wird an dritte weiterverkauft oder ausgenutzt. Sie sind bei uns sicher aufbewahrt. Sie dürfen auch jederzeit einen Antrag stellen um ihre Daten zu löschen.";

                case "Ist die App sicher für Kinder?":
                    return "FuturArtX ist für alle Altersgruppen geeignet. Wenn Ihr Kind jedoch keine zeichnungen von Nackten Menschen sehen sollte, ist die App eher weniger geeignet da es einige Exponate gibt die freizügiger sind.";

                default:
                    return "Antwort nicht verfügbar.";
            }
    }
}