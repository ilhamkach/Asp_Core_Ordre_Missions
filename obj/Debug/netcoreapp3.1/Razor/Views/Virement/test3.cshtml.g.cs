#pragma checksum "C:\Users\MON PC\Desktop\c# et la programmation .net\projet_migration_copie\gestion_ordre_mission\Views\Virement\test3.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e1ac6f54823e3fdf8481a8c09394a55a6a275e1c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Virement_test3), @"mvc.1.0.view", @"/Views/Virement/test3.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1ac6f54823e3fdf8481a8c09394a55a6a275e1c", @"/Views/Virement/test3.cshtml")]
    public class Views_Virement_test3 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e1ac6f54823e3fdf8481a8c09394a55a6a275e1c2776", async() => {
                WriteLiteral(@"
    <title>pages</title>
    <style>

        table {
            width: 100%;
        }

        th {
            background-color: #696969;
            color: #fff;
        }

        p {
            padding: 5px;
            width: 100%;
        }

        table {
            border: 1px solid black;
        }

        .p1 {
            border-width: 2px;
            border-style: solid;
        }

        table {
            border-collapse: collapse
        }

        td {
            border: 1px solid black;
            text-align: left;
            padding: 0px;
        }

        .a {
            border: 1px solid black;
            text-align: center;
            padding: 0px
        }

        .b {
            text-align: center;
        }
    </style>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e1ac6f54823e3fdf8481a8c09394a55a6a275e1c4560", async() => {
                WriteLiteral("\r\n    <table>\r\n        <tr>\r\n            <td class=\"a\"><p>UNIVERSITE CADI AYYAD</p><p>ECOLE NATIONALE DES SCIENCES APPLIQUEES</p><p>B.P, route Sidi Bouzid </p><br><p>Safi</p></td>\r\n            <td class=\"a\"><h2>ORDRE DE PAIEMENT </h2><br /><p>");
#nullable restore
#line 57 "C:\Users\MON PC\Desktop\c# et la programmation .net\projet_migration_copie\gestion_ordre_mission\Views\Virement\test3.cshtml"
                                                         Write(ViewBag.numop);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"/2021</p><p>Budget de Fonctionnement</p> </td>
            <td class=""a"">

                <p>Année d'origine de la créance : 2021<br> COMPTE Nº 49531<br> OUVERT A LA TRESORERIE<br>REGIONALE DE SAFI</p>
            </td>
        </tr>
    </table>
    <br>
    <p class=""p1"">
        Bénéficière : ");
#nullable restore
#line 66 "C:\Users\MON PC\Desktop\c# et la programmation .net\projet_migration_copie\gestion_ordre_mission\Views\Virement\test3.cshtml"
                 Write(ViewData["nompers"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"<br>
        Domiciliation : &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Safi
    </p>

    <br>

    <table>
        <thead>
            <tr>
                <th>PIECES JUSTIFICATIVES</th>
                <th>Chapitre</th>
                <th>ART</th>
                <th>&</th>
                <th>Lig</th>
                <th>Crédit Ouvert</th>
                <th>NATURE DES OPERATIONS</th>
                <th>Montant</th>
            </tr>
        </thead>
        <tbody>
            <tr>
                <td rowspan=""4"">
                    Etat des indimnités de déplacement <br><br><br>
                    Ordre de mission 208/2021<br><br><br><br><br><br><br><br><br>
                </td>
                <td>MDD<br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br></td>
           ");
                WriteLiteral("     <td>");
#nullable restore
#line 92 "C:\Users\MON PC\Desktop\c# et la programmation .net\projet_migration_copie\gestion_ordre_mission\Views\Virement\test3.cshtml"
               Write(ViewData["art"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("<br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br></td>\r\n                <td>");
#nullable restore
#line 93 "C:\Users\MON PC\Desktop\c# et la programmation .net\projet_migration_copie\gestion_ordre_mission\Views\Virement\test3.cshtml"
               Write(ViewData["num1"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("<br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br></td>\r\n                <td>");
#nullable restore
#line 94 "C:\Users\MON PC\Desktop\c# et la programmation .net\projet_migration_copie\gestion_ordre_mission\Views\Virement\test3.cshtml"
               Write(ViewData["num2"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"<br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br></td>
                <td rowspan=""4"">Crédit en cours<br><br><br><br><br><br><br><br><br><br><br><br><br><br><br></td>
                <td rowspan=""4"">
                    Intitulé de l'article : Pilotage de Gouvernance <br><br> Intitulé de &: Rayonnement et ouverture<br><hr> Intitulé de la Lig : Indémnités de déplacement à l'interieur du Royaume
                    <br><br><br><br><br><br><br><br><br><p class=""b"">Certification de liquidation par le service concerné</p><br>
                </td>
                <td>");
#nullable restore
#line 100 "C:\Users\MON PC\Desktop\c# et la programmation .net\projet_migration_copie\gestion_ordre_mission\Views\Virement\test3.cshtml"
               Write(ViewData["TotaleDeplacement"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"<br><br><br><br><br><br><br><br><br><br><br><br><br><br><br></td>


        </tbody>

    </table>
    <table>
        <tr>
            <td colspan=""8"">arrêté le présent Ordre de Paiement à la somme de : Quatre cent quatre vignt dirhams </td>
            <td>");
#nullable restore
#line 109 "C:\Users\MON PC\Desktop\c# et la programmation .net\projet_migration_copie\gestion_ordre_mission\Views\Virement\test3.cshtml"
           Write(ViewData["TotaleDeplacement"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</td>
        </tr>
    </table>
    <br>
    <br>
    <table>

        <thead>
            <tr>
                <th>LES SOUS ORDONNATEUR</th>
                <th>LE FONDE DE POUVOIRS</th>
            </tr>
        </thead>
        <tbody>
            <tr>
                <td><br>Transmis au fondé de pouvoirs le : <br> <br><br>Signature du sous Ordonnateur : <br><br><br><br><br><br><br><br><br><br><br></td>
                <td><br>Mode de réglement :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;OV nº ");
#nullable restore
#line 125 "C:\Users\MON PC\Desktop\c# et la programmation .net\projet_migration_copie\gestion_ordre_mission\Views\Virement\test3.cshtml"
                                                                                                                                      Write(ViewBag.numv);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;     BP         <br>  <br><br>Date de réglement : <br> <br><br> Visa du fondé de pouvoirs : <br><br><br><br><br><br><br><br><br><br><br></td>
            </tr>
        </tbody>
    </table>
    <p style=""margin-left:30px;float:left;"">Dossier établis par: ");
#nullable restore
#line 129 "C:\Users\MON PC\Desktop\c# et la programmation .net\projet_migration_copie\gestion_ordre_mission\Views\Virement\test3.cshtml"
                                                            Write(ViewBag.faitpart);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  Safi le : ");
#nullable restore
#line 129 "C:\Users\MON PC\Desktop\c# et la programmation .net\projet_migration_copie\gestion_ordre_mission\Views\Virement\test3.cshtml"
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        Write(ViewData["date"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591