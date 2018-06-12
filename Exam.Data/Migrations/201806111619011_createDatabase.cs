namespace Exam.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Assures",
                c => new
                    {
                        AssureId = c.Int(nullable: false),
                        TypeAssure = c.String(),
                        TypeIdentifiant = c.String(),
                        NumeroIdentifiant = c.Int(nullable: false),
                        DateDelivreIdentifiant = c.String(),
                        Nom = c.String(),
                        Prenom = c.String(),
                        DateDeNaissance = c.String(),
                        LieuDeNaissance = c.String(),
                        Sexe = c.String(),
                        SituationFamiliale = c.String(),
                        Profession = c.String(),
                        NumeroPermis = c.String(),
                        DateDelivrePermis = c.String(),
                        Addresse_Adresse = c.String(),
                        Addresse_Ville = c.String(),
                        Addresse_CodePostal = c.Int(nullable: false),
                        Contact_Telephone = c.Int(),
                        Contact_Mobile = c.Int(),
                        Contact_Fax = c.Int(),
                        Contact_Email = c.String(),
                    })
                .PrimaryKey(t => t.AssureId)
                .ForeignKey("dbo.UserAccounts", t => t.AssureId)
                .Index(t => t.AssureId);
            
            CreateTable(
                "dbo.Contrats",
                c => new
                    {
                        ContratId = c.Int(nullable: false),
                        ContratName = c.String(),
                        Compagnie = c.String(),
                        Agence = c.String(),
                        Categorie = c.String(),
                        DateSouscription = c.String(),
                        DateEffet = c.String(),
                        Periodicite = c.String(),
                        Fractionnement = c.Int(nullable: false),
                        DateEcheance = c.String(),
                        PrimeAnnuelle = c.Int(nullable: false),
                        PrimeComptant = c.Int(nullable: false),
                        SouscripteurId = c.Int(nullable: false),
                        AssureId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ContratId)
                .ForeignKey("dbo.Assures", t => t.AssureId, cascadeDelete: true)
                .ForeignKey("dbo.Souscripteurs", t => t.SouscripteurId, cascadeDelete: true)
                .ForeignKey("dbo.Vehicules", t => t.ContratId)
                .Index(t => t.ContratId)
                .Index(t => t.SouscripteurId)
                .Index(t => t.AssureId);
            
            CreateTable(
                "dbo.ContratGaranties",
                c => new
                    {
                        ContratId = c.Int(nullable: false),
                        GarantieId = c.Int(nullable: false),
                        Capital = c.Int(nullable: false),
                        Franchise = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ContratId, t.GarantieId })
                .ForeignKey("dbo.Contrats", t => t.ContratId, cascadeDelete: true)
                .ForeignKey("dbo.Garanties", t => t.GarantieId, cascadeDelete: true)
                .Index(t => t.ContratId)
                .Index(t => t.GarantieId);
            
            CreateTable(
                "dbo.Garanties",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GarantieName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Sinistres",
                c => new
                    {
                        SinistreId = c.Int(nullable: false, identity: true),
                        DateSinistre = c.String(),
                        Nature = c.String(),
                        Phase = c.String(),
                        Etat = c.String(),
                        Conducteur = c.String(),
                        Indemnise = c.Boolean(nullable: false),
                        IDA = c.Boolean(nullable: false),
                        GarantieSinistre = c.String(),
                        NumeroPermis = c.String(),
                        PartDeResponsabilite = c.Int(nullable: false),
                        MontantIndemnisation = c.Int(nullable: false),
                        CompagnieAdverse = c.String(),
                        DateDePermis = c.String(),
                        DateIndemnisation = c.String(),
                        VehiculeAdverse = c.String(),
                        ContratId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SinistreId)
                .ForeignKey("dbo.Contrats", t => t.ContratId, cascadeDelete: true)
                .Index(t => t.ContratId);
            
            CreateTable(
                "dbo.BonDeSorties",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateCreation = c.String(),
                        BonDeSortieNonSigne = c.String(),
                        BonDeSortieSigne = c.String(),
                        SinistreId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Sinistres", t => t.SinistreId, cascadeDelete: true)
                .Index(t => t.SinistreId);
            
            CreateTable(
                "dbo.Confirmations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateVersion = c.String(),
                        Version = c.Int(nullable: false),
                        Rapport = c.String(),
                        SinistreId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Sinistres", t => t.SinistreId, cascadeDelete: true)
                .Index(t => t.SinistreId);
            
            CreateTable(
                "dbo.Devis",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SinistreId = c.Int(nullable: false),
                        DateDevis = c.String(),
                        Conformite = c.String(),
                        DevisUrl = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Sinistres", t => t.SinistreId, cascadeDelete: true)
                .Index(t => t.SinistreId);
            
            CreateTable(
                "dbo.Factures",
                c => new
                    {
                        FactureId = c.Int(nullable: false, identity: true),
                        DateFacture = c.String(),
                        Description = c.String(),
                        Montant = c.Int(nullable: false),
                        SinistreId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.FactureId)
                .ForeignKey("dbo.Sinistres", t => t.SinistreId, cascadeDelete: true)
                .Index(t => t.SinistreId);
            
            CreateTable(
                "dbo.UserAccounts",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        PhoneNumber = c.Int(nullable: false),
                        Role = c.String(),
                    })
                .PrimaryKey(t => t.UserId);
            
            CreateTable(
                "dbo.ImageSinistres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ImageLink = c.String(),
                        ImageName = c.String(),
                        Extension = c.String(),
                        SinistreId = c.Int(nullable: false),
                        Status = c.String(),
                        DateImage = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Sinistres", t => t.SinistreId, cascadeDelete: true)
                .Index(t => t.SinistreId);
            
            CreateTable(
                "dbo.Rapports",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateRapport = c.String(),
                        RapportName = c.String(),
                        RapportUrl = c.String(),
                        RapportExtension = c.String(),
                        Version = c.Int(nullable: false),
                        SinistreId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Sinistres", t => t.SinistreId, cascadeDelete: true)
                .Index(t => t.SinistreId);
            
            CreateTable(
                "dbo.Souscripteurs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nom = c.String(),
                        TypeSouscripteur = c.String(),
                        TypeIdentifiant = c.String(),
                        Numero = c.String(),
                        DateDelivre = c.String(),
                        RaisonSocial = c.String(),
                        FormeJuridique = c.String(),
                        DateCreation = c.String(),
                        Activite = c.String(),
                        Addresse_Adresse = c.String(),
                        Addresse_Ville = c.String(),
                        Addresse_CodePostal = c.Int(nullable: false),
                        Contact_Telephone = c.Int(),
                        Contact_Mobile = c.Int(),
                        Contact_Fax = c.Int(),
                        Contact_Email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Vehicules",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Matricule = c.String(),
                        Genre = c.String(),
                        Usage = c.String(),
                        Constructeur = c.String(),
                        Marque = c.String(),
                        Couleur = c.String(),
                        TypeConstructeur = c.String(),
                        NumeroDeSerie = c.String(),
                        DPMC = c.String(),
                        Carrosserie = c.String(),
                        NombreDePlace = c.Int(nullable: false),
                        NombreDebout = c.Int(),
                        Energie = c.String(),
                        PuissanceFiscale = c.Int(),
                        Cylindree = c.Int(),
                        PoidVide = c.Int(),
                        CHargeUtile = c.Int(),
                        PTAC = c.Int(),
                        NumeroRemorque = c.Int(),
                        TypeRemorque = c.String(),
                        PoidVideRemorque = c.Int(),
                        ChargeUtileRemorque = c.Int(),
                        Delegation = c.Boolean(nullable: false),
                        Organisme = c.String(),
                        Duree = c.Int(),
                        ValeurANeuf = c.Int(),
                        ValeurVenale = c.Int(),
                        Classe = c.Int(),
                        Companie = c.String(),
                        DateReleve = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Reclamations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Titre = c.String(),
                        Description = c.String(),
                        Date = c.String(),
                        AssureId = c.Int(nullable: false),
                        status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Assures", t => t.AssureId, cascadeDelete: true)
                .Index(t => t.AssureId);
            
            CreateTable(
                "dbo.UsersSinistres",
                c => new
                    {
                        SinistreId = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.SinistreId, t.UserId })
                .ForeignKey("dbo.Sinistres", t => t.SinistreId, cascadeDelete: true)
                .ForeignKey("dbo.UserAccounts", t => t.UserId, cascadeDelete: true)
                .Index(t => t.SinistreId)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Assures", "AssureId", "dbo.UserAccounts");
            DropForeignKey("dbo.Reclamations", "AssureId", "dbo.Assures");
            DropForeignKey("dbo.Contrats", "ContratId", "dbo.Vehicules");
            DropForeignKey("dbo.Contrats", "SouscripteurId", "dbo.Souscripteurs");
            DropForeignKey("dbo.Rapports", "SinistreId", "dbo.Sinistres");
            DropForeignKey("dbo.ImageSinistres", "SinistreId", "dbo.Sinistres");
            DropForeignKey("dbo.UsersSinistres", "UserId", "dbo.UserAccounts");
            DropForeignKey("dbo.UsersSinistres", "SinistreId", "dbo.Sinistres");
            DropForeignKey("dbo.Factures", "SinistreId", "dbo.Sinistres");
            DropForeignKey("dbo.Devis", "SinistreId", "dbo.Sinistres");
            DropForeignKey("dbo.Sinistres", "ContratId", "dbo.Contrats");
            DropForeignKey("dbo.Confirmations", "SinistreId", "dbo.Sinistres");
            DropForeignKey("dbo.BonDeSorties", "SinistreId", "dbo.Sinistres");
            DropForeignKey("dbo.ContratGaranties", "GarantieId", "dbo.Garanties");
            DropForeignKey("dbo.ContratGaranties", "ContratId", "dbo.Contrats");
            DropForeignKey("dbo.Contrats", "AssureId", "dbo.Assures");
            DropIndex("dbo.UsersSinistres", new[] { "UserId" });
            DropIndex("dbo.UsersSinistres", new[] { "SinistreId" });
            DropIndex("dbo.Reclamations", new[] { "AssureId" });
            DropIndex("dbo.Rapports", new[] { "SinistreId" });
            DropIndex("dbo.ImageSinistres", new[] { "SinistreId" });
            DropIndex("dbo.Factures", new[] { "SinistreId" });
            DropIndex("dbo.Devis", new[] { "SinistreId" });
            DropIndex("dbo.Confirmations", new[] { "SinistreId" });
            DropIndex("dbo.BonDeSorties", new[] { "SinistreId" });
            DropIndex("dbo.Sinistres", new[] { "ContratId" });
            DropIndex("dbo.ContratGaranties", new[] { "GarantieId" });
            DropIndex("dbo.ContratGaranties", new[] { "ContratId" });
            DropIndex("dbo.Contrats", new[] { "AssureId" });
            DropIndex("dbo.Contrats", new[] { "SouscripteurId" });
            DropIndex("dbo.Contrats", new[] { "ContratId" });
            DropIndex("dbo.Assures", new[] { "AssureId" });
            DropTable("dbo.UsersSinistres");
            DropTable("dbo.Reclamations");
            DropTable("dbo.Vehicules");
            DropTable("dbo.Souscripteurs");
            DropTable("dbo.Rapports");
            DropTable("dbo.ImageSinistres");
            DropTable("dbo.UserAccounts");
            DropTable("dbo.Factures");
            DropTable("dbo.Devis");
            DropTable("dbo.Confirmations");
            DropTable("dbo.BonDeSorties");
            DropTable("dbo.Sinistres");
            DropTable("dbo.Garanties");
            DropTable("dbo.ContratGaranties");
            DropTable("dbo.Contrats");
            DropTable("dbo.Assures");
        }
    }
}
