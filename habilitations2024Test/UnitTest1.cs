namespace habilitations2024Test;

public class UnitTest1
{
    [Fact]
    public void GetLesDeveloppeurs_ProfilSelectionne_RetourneBonNombre()
    {
        // Arrange
        var controller = new FrmHabilitationsController();
        int idProfilTest = 5; 
        int nombreAttendu = 6; 

        // Act
        List<Developpeur> resultats = controller.GetLesDeveloppeurs(idProfilTest);

        // Assert
        Assert.Equal(nombreAttendu, resultats.Count);
    }
    [Fact]
    public void GetLesDeveloppeurs_AucunProfilSelectionne_RetourneTousLesDeveloppeurs()
    {
        // Arrange
        var controller = new FrmHabilitationsController();
        int nombreTotalAttendu = 20; 

        // Act
        List<Developpeur> resultats = controller.GetLesDeveloppeurs();

        // Assert
        Assert.Equal(nombreTotalAttendu, resultats.Count);
    }

}
