using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace FuturArtXTrue;

public partial class HomePage : ContentPage
{
    public HomePage()
    {
        InitializeComponent();
    }
    public void ChangePageExponatSpecificSternenNacht(object sender, EventArgs e)
    {
        App.Current.MainPage = new ExponatPage("DIE STERNENNACHT","MIT SCHWUNG","\"Sternennacht\" von Vincent van Gogh, geschaffen im Jahr 1889, ist zweifellos eines der eindrucksvollsten Gemälde des niederländischen Künstlers. Dieses Meisterwerk fängt die Essenz von van Goghs kreativer Leidenschaft und seiner einzigartigen Vorstellungskraft ein.\n\nDas Gemälde präsentiert eine nächtliche Szene, in der ein Dorf unter einem wirbelnden Himmel aus Sternen liegt. Van Gogh verwendet intensive Farben und kräftige Pinselstriche, um eine lebendige Darstellung zu schaffen, die die Landschaft in einen magischen, fast träumerischen Zustand versetzt. Die Sterne am Himmel pulsieren förmlich vor Energie, und die Wirbel und Linien verleihen dem Bild eine dynamische Bewegung.\n\nVan Goghs einzigartiger Stil, der als Post-Impressionismus bekannt ist, manifestiert sich in \"Sternennacht\" durch die Verwendung von expressiven Farben und dem Verzicht auf realistische Details. Der Künstler schuf ein Werk, das nicht nur die physische Realität einfängt, sondern auch seine eigene emotionale und spirituelle Wahrnehmung der Welt widerspiegelt.\n\nDer Blick auf \"Sternennacht\" lässt uns in die Psyche van Goghs eintauchen, der während der Entstehung dieses Gemäldes in einer psychiatrischen Anstalt war. Die Kombination von intensiven Farben und einer fast chaotischen Darstellung des Himmels vermittelt einen Eindruck von innerer Turbulenz und gleichzeitig von ästhetischem Genie.\n\nDieses Exponat lädt dazu ein, sich von der Magie und der Einzigartigkeit von van Goghs Schaffen verzaubern zu lassen. \"Sternennacht\" bleibt ein zeitloses Beispiel für die transformative Kraft der Kunst und die Fähigkeit des Künstlers, die Schönheit des Universums auf unvergleichliche Weise zu interpretieren.","kunst1.png");
    }
    public void ChangePageExponatSpecificSchrei(object sender, EventArgs e)
    {
        App.Current.MainPage = new ExponatPage("DER SCHREI","DER NACHKLINGT","\"Der Schrei\" von Edvard Munch, geschaffen im Jahr 1893, ist ein Schlüsselwerk der symbolistischen Bewegung und verkörpert die Essenz des existentialistischen Ausdrucks.\n\nDas Gemälde zeigt eine schemenhafte Figur auf einer Brücke, umgeben von einer verzerrten Landschaft. Zerrissene Wolken und ein leuchtend roter Himmel verstärken das Gefühl der Verzweiflung. Das entstellte Gesicht der Figur und die weit aufgerissenen Augen vermitteln einen stummen Schrei, der Munchs persönliche Krise widerspiegelt und gleichzeitig eine universelle Erfahrung anspricht.\n\nDie kräftigen Farben intensivieren die emotionalen Turbulenzen, während Munchs künstlerische Technik dazu beiträgt, die innere Zerrissenheit der Figur zu vermitteln. \"Der Schrei\" ist nicht nur ein individueller Ausdruck von Munchs inneren Kämpfen, sondern auch ein Spiegelbild der Unsicherheiten und Ängste in der damaligen Gesellschaft.\n\nDieses Exponat lädt dazu ein, in die tiefen Abgründe der menschlichen Seele zu blicken und sich mit den existenziellen Fragen auseinanderzusetzen, die auch heute noch aktuell sind. \"Der Schrei\" von Edvard Munch bleibt ein kraftvolles Zeugnis für die menschliche Existenz und ihre existenziellen Herausforderungen.","kunst2.png");
    }
}