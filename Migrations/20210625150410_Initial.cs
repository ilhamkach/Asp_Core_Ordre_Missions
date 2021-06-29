using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace gestion_ordre_mission.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "corp",
                columns: table => new
                {
                    Idcorps = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_corp", x => x.Idcorps);
                });

            migrationBuilder.CreateTable(
                name: "param_paiement",
                columns: table => new
                {
                    id_param_paiement = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Art = table.Column<int>(nullable: false),
                    num1 = table.Column<int>(nullable: false),
                    num2 = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_param_paiement", x => x.id_param_paiement);
                });

            migrationBuilder.CreateTable(
                name: "param_voiture",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre_cheveau_min = table.Column<int>(nullable: false),
                    nombre_cheveau_max = table.Column<int>(nullable: false),
                    prix_par_km = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_param_voiture", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "parametre",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nom = table.Column<string>(nullable: true),
                    valeur1 = table.Column<int>(nullable: false),
                    valeur2 = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_parametre", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "parametre_img",
                columns: table => new
                {
                    id_param_img = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    type = table.Column<string>(nullable: true),
                    footer = table.Column<string>(nullable: true),
                    header = table.Column<string>(nullable: true),
                    background = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_parametre_img", x => x.id_param_img);
                });

            migrationBuilder.CreateTable(
                name: "trajet",
                columns: table => new
                {
                    id_trajet = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    villeDepart = table.Column<string>(nullable: true),
                    villeArrivee = table.Column<string>(nullable: true),
                    distance = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_trajet", x => x.id_trajet);
                });

            migrationBuilder.CreateTable(
                name: "cadres",
                columns: table => new
                {
                    IdCadre = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(nullable: false),
                    NomComplet = table.Column<string>(nullable: true),
                    Idcorps = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cadres", x => x.IdCadre);
                    table.ForeignKey(
                        name: "FK_cadres_corp_Idcorps",
                        column: x => x.Idcorps,
                        principalTable: "corp",
                        principalColumn: "Idcorps",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "grade",
                columns: table => new
                {
                    Idgrades = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(nullable: false),
                    NomComplet = table.Column<string>(nullable: true),
                    Nomarabe = table.Column<string>(nullable: true),
                    IdCadre = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_grade", x => x.Idgrades);
                    table.ForeignKey(
                        name: "FK_grade_cadres_IdCadre",
                        column: x => x.IdCadre,
                        principalTable: "cadres",
                        principalColumn: "IdCadre",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "personnels",
                columns: table => new
                {
                    IdPers = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(nullable: false),
                    Prenom = table.Column<string>(nullable: false),
                    nomarabe = table.Column<string>(nullable: true),
                    prenomarabe = table.Column<string>(nullable: true),
                    Username = table.Column<string>(nullable: true),
                    Role = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    CIN = table.Column<string>(nullable: false),
                    DRPP = table.Column<string>(nullable: true),
                    Email1 = table.Column<string>(nullable: false),
                    Email2 = table.Column<string>(nullable: true),
                    Adresse = table.Column<string>(nullable: true),
                    Ville = table.Column<string>(nullable: true),
                    Sexe = table.Column<string>(nullable: true),
                    Gsm1 = table.Column<string>(nullable: true),
                    Gsm2 = table.Column<string>(nullable: true),
                    liencv = table.Column<string>(nullable: true),
                    ServiceAffecte = table.Column<string>(nullable: true),
                    SituationAdministratif = table.Column<string>(nullable: false),
                    SituationFamiliale = table.Column<string>(nullable: true),
                    NombreEnfant = table.Column<int>(nullable: false),
                    DateNaissance = table.Column<DateTime>(nullable: false),
                    DateRecrutement = table.Column<DateTime>(nullable: false),
                    DateRecrutementENSA = table.Column<DateTime>(nullable: false),
                    DateEffetgrade = table.Column<DateTime>(nullable: false),
                    DateEffetEchelon = table.Column<DateTime>(nullable: false),
                    DateDebut = table.Column<DateTime>(nullable: false),
                    DateFin = table.Column<DateTime>(nullable: false),
                    renouvelement = table.Column<string>(nullable: true),
                    specialite = table.Column<string>(nullable: true),
                    diplome = table.Column<string>(nullable: true),
                    ecolediplome = table.Column<string>(nullable: true),
                    anneediplome = table.Column<string>(nullable: true),
                    photo = table.Column<string>(nullable: true),
                    show1 = table.Column<bool>(nullable: false),
                    show2 = table.Column<bool>(nullable: false),
                    echelon = table.Column<int>(nullable: false),
                    Echelle = table.Column<int>(nullable: false),
                    TypeqEntiterecherches = table.Column<string>(nullable: true),
                    Nomentiterecherches = table.Column<string>(nullable: true),
                    Lieuentiterecherches = table.Column<string>(nullable: true),
                    Thematiquerecherches = table.Column<string>(nullable: true),
                    Journauxrecherches = table.Column<string>(nullable: true),
                    NomCorps = table.Column<string>(nullable: false),
                    NomCadre = table.Column<string>(nullable: true),
                    NomGrades = table.Column<string>(nullable: true),
                    Idcorps = table.Column<int>(nullable: true),
                    IdCadre = table.Column<int>(nullable: true),
                    Idgrades = table.Column<int>(nullable: true),
                    Typecontract = table.Column<string>(nullable: true),
                    NumContract = table.Column<string>(nullable: true),
                    Société = table.Column<string>(nullable: true),
                    DateContract = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_personnels", x => x.IdPers);
                    table.ForeignKey(
                        name: "FK_personnels_cadres_IdCadre",
                        column: x => x.IdCadre,
                        principalTable: "cadres",
                        principalColumn: "IdCadre",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_personnels_corp_Idcorps",
                        column: x => x.Idcorps,
                        principalTable: "corp",
                        principalColumn: "Idcorps",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_personnels_grade_Idgrades",
                        column: x => x.Idgrades,
                        principalTable: "grade",
                        principalColumn: "Idgrades",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ordremission",
                columns: table => new
                {
                    idOrdremission = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    numero = table.Column<string>(nullable: true),
                    etat = table.Column<bool>(nullable: false),
                    dateDepart = table.Column<DateTime>(nullable: false),
                    dateArrivee = table.Column<DateTime>(nullable: false),
                    heureDepart = table.Column<string>(nullable: true),
                    heureArrivee = table.Column<string>(nullable: true),
                    echlon = table.Column<int>(nullable: false),
                    matricule = table.Column<string>(nullable: true),
                    grade = table.Column<string>(nullable: true),
                    objetDepart = table.Column<string>(nullable: true),
                    moyenTransport = table.Column<string>(nullable: true),
                    nombreCheuvaux = table.Column<int>(nullable: false),
                    montant_total = table.Column<float>(nullable: false),
                    IdPers = table.Column<int>(nullable: false),
                    id_trajet = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ordremission", x => x.idOrdremission);
                    table.ForeignKey(
                        name: "FK_ordremission_personnels_IdPers",
                        column: x => x.IdPers,
                        principalTable: "personnels",
                        principalColumn: "IdPers",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ordremission_trajet_id_trajet",
                        column: x => x.id_trajet,
                        principalTable: "trajet",
                        principalColumn: "id_trajet",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ordrepaiement",
                columns: table => new
                {
                    IdOrderPaiement = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    totalDeplacement = table.Column<double>(nullable: false),
                    tatalKilo = table.Column<double>(nullable: false),
                    idOrdreVirement = table.Column<int>(nullable: true),
                    id_mission = table.Column<int>(nullable: false),
                    ordermissionidOrdremission = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ordrepaiement", x => x.IdOrderPaiement);
                    table.ForeignKey(
                        name: "FK_ordrepaiement_ordremission_ordermissionidOrdremission",
                        column: x => x.ordermissionidOrdremission,
                        principalTable: "ordremission",
                        principalColumn: "idOrdremission",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrdrePayment",
                columns: table => new
                {
                    IdOrdrePayment = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    totalDeplacement = table.Column<double>(nullable: false),
                    tatalKilo = table.Column<double>(nullable: false),
                    idOrdreVirement = table.Column<int>(nullable: true),
                    idOrdremission = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdrePayment", x => x.IdOrdrePayment);
                    table.ForeignKey(
                        name: "FK_OrdrePayment_ordremission_idOrdremission",
                        column: x => x.idOrdremission,
                        principalTable: "ordremission",
                        principalColumn: "idOrdremission",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ordrevirement",
                columns: table => new
                {
                    IdOrdreVirement = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    numero = table.Column<string>(nullable: true),
                    idAdmin = table.Column<int>(nullable: false),
                    numeroCompte = table.Column<string>(nullable: true),
                    IdOrdrePayment = table.Column<int>(nullable: false),
                    IdOrderPaiement = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ordrevirement", x => x.IdOrdreVirement);
                    table.ForeignKey(
                        name: "FK_ordrevirement_ordrepaiement_IdOrderPaiement",
                        column: x => x.IdOrderPaiement,
                        principalTable: "ordrepaiement",
                        principalColumn: "IdOrderPaiement");
                    table.ForeignKey(
                        name: "FK_ordrevirement_OrdrePayment_IdOrdrePayment",
                        column: x => x.IdOrdrePayment,
                        principalTable: "OrdrePayment",
                        principalColumn: "IdOrdrePayment");
                });

            migrationBuilder.CreateIndex(
                name: "IX_cadres_Idcorps",
                table: "cadres",
                column: "Idcorps");

            migrationBuilder.CreateIndex(
                name: "IX_grade_IdCadre",
                table: "grade",
                column: "IdCadre");

            migrationBuilder.CreateIndex(
                name: "IX_ordremission_IdPers",
                table: "ordremission",
                column: "IdPers");

            migrationBuilder.CreateIndex(
                name: "IX_ordremission_id_trajet",
                table: "ordremission",
                column: "id_trajet");

            migrationBuilder.CreateIndex(
                name: "IX_ordrepaiement_idOrdreVirement",
                table: "ordrepaiement",
                column: "idOrdreVirement");

            migrationBuilder.CreateIndex(
                name: "IX_ordrepaiement_ordermissionidOrdremission",
                table: "ordrepaiement",
                column: "ordermissionidOrdremission");

            migrationBuilder.CreateIndex(
                name: "IX_OrdrePayment_idOrdreVirement",
                table: "OrdrePayment",
                column: "idOrdreVirement");

            migrationBuilder.CreateIndex(
                name: "IX_OrdrePayment_idOrdremission",
                table: "OrdrePayment",
                column: "idOrdremission");

            migrationBuilder.CreateIndex(
                name: "IX_ordrevirement_IdOrderPaiement",
                table: "ordrevirement",
                column: "IdOrderPaiement");

            migrationBuilder.CreateIndex(
                name: "IX_ordrevirement_IdOrdrePayment",
                table: "ordrevirement",
                column: "IdOrdrePayment");

            migrationBuilder.CreateIndex(
                name: "IX_personnels_IdCadre",
                table: "personnels",
                column: "IdCadre");

            migrationBuilder.CreateIndex(
                name: "IX_personnels_Idcorps",
                table: "personnels",
                column: "Idcorps");

            migrationBuilder.CreateIndex(
                name: "IX_personnels_Idgrades",
                table: "personnels",
                column: "Idgrades");

            migrationBuilder.AddForeignKey(
                name: "FK_ordrepaiement_ordrevirement_idOrdreVirement",
                table: "ordrepaiement",
                column: "idOrdreVirement",
                principalTable: "ordrevirement",
                principalColumn: "IdOrdreVirement",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrdrePayment_ordrevirement_idOrdreVirement",
                table: "OrdrePayment",
                column: "idOrdreVirement",
                principalTable: "ordrevirement",
                principalColumn: "IdOrdreVirement",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cadres_corp_Idcorps",
                table: "cadres");

            migrationBuilder.DropForeignKey(
                name: "FK_personnels_corp_Idcorps",
                table: "personnels");

            migrationBuilder.DropForeignKey(
                name: "FK_grade_cadres_IdCadre",
                table: "grade");

            migrationBuilder.DropForeignKey(
                name: "FK_personnels_cadres_IdCadre",
                table: "personnels");

            migrationBuilder.DropForeignKey(
                name: "FK_ordremission_personnels_IdPers",
                table: "ordremission");

            migrationBuilder.DropForeignKey(
                name: "FK_ordremission_trajet_id_trajet",
                table: "ordremission");

            migrationBuilder.DropForeignKey(
                name: "FK_ordrepaiement_ordrevirement_idOrdreVirement",
                table: "ordrepaiement");

            migrationBuilder.DropForeignKey(
                name: "FK_OrdrePayment_ordrevirement_idOrdreVirement",
                table: "OrdrePayment");

            migrationBuilder.DropTable(
                name: "param_paiement");

            migrationBuilder.DropTable(
                name: "param_voiture");

            migrationBuilder.DropTable(
                name: "parametre");

            migrationBuilder.DropTable(
                name: "parametre_img");

            migrationBuilder.DropTable(
                name: "corp");

            migrationBuilder.DropTable(
                name: "cadres");

            migrationBuilder.DropTable(
                name: "personnels");

            migrationBuilder.DropTable(
                name: "grade");

            migrationBuilder.DropTable(
                name: "trajet");

            migrationBuilder.DropTable(
                name: "ordrevirement");

            migrationBuilder.DropTable(
                name: "ordrepaiement");

            migrationBuilder.DropTable(
                name: "OrdrePayment");

            migrationBuilder.DropTable(
                name: "ordremission");
        }
    }
}
