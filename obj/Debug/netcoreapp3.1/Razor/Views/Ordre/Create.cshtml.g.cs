#pragma checksum "C:\Users\MON PC\Desktop\c# et la programmation .net\projet_migration_copie\gestion_ordre_mission\Views\Ordre\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "769c8775e213b4ec813f8b272779a2bea80e4078"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ordre_Create), @"mvc.1.0.view", @"/Views/Ordre/Create.cshtml")]
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
#nullable restore
#line 5 "C:\Users\MON PC\Desktop\c# et la programmation .net\projet_migration_copie\gestion_ordre_mission\Views\Ordre\Create.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"769c8775e213b4ec813f8b272779a2bea80e4078", @"/Views/Ordre/Create.cshtml")]
    public class Views_Ordre_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<gestion_ordre_mission.Models.OrdreMission>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\MON PC\Desktop\c# et la programmation .net\projet_migration_copie\gestion_ordre_mission\Views\Ordre\Create.cshtml"
  
    Layout = "~/Views/Shared/MenuLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- Custom fonts for this template -->
<
<!-- Custom styles for this template -->
<link href=""../Content/css/sb-admin-2.min.css"" rel=""stylesheet"">

<!-- Custom styles for this page -->
<!-- Page Wrapper -->
<div id=""wrapper"">

    <!-- Sidebar -->
    <!-- End of Sidebar -->
    <!-- Content Wrapper -->
    <div id=""content-wrapper"" class=""d-flex flex-column"">

        <!-- Main Content -->
        <div id=""content"" style=""width:1200px"">

            <!-- Topbar -->
            <nav class=""navbar navbar-expand navbar-light bg-white topbar mb-4 static-top shadow"">

                <!-- Sidebar Toggle (Topbar) -->
                <button id=""sidebarToggleTop"" class=""btn btn-link d-md-none rounded-circle mr-3"">
                    <i class=""fa fa-bars""></i>
                </button>



                <!-- Topbar Navbar -->
                <ul class=""navbar-nav ml-auto"">
                    <div class=""topbar-divider d-none d-sm-block""></div>

                    <!-- Nav Item - U");
            WriteLiteral(@"ser Information -->
                    <li class=""nav-item dropdown no-arrow"">
                        <a class=""nav-link dropdown-toggle"" href=""#"" id=""userDropdown"" role=""button""
                           data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                            <span class=""mr-2 d-none d-lg-inline text-gray-600 small"">");
#nullable restore
#line 41 "C:\Users\MON PC\Desktop\c# et la programmation .net\projet_migration_copie\gestion_ordre_mission\Views\Ordre\Create.cshtml"
                                                                                 Write(Context.Session.GetString("nomeconomique"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                            <img class=""img-profile rounded-circle""
                                 src=""../Content/img/undraw_profile.svg"">
                        </a>
                        <!-- Dropdown - User Information -->
                        <div class=""dropdown-menu dropdown-menu-right shadow animated--grow-in""
                             aria-labelledby=""userDropdown"">

                            <a class=""dropdown-item"" href=""/Parametrage/Index"">
                                <i class=""fas fa-cogs fa-sm fa-fw mr-2 text-gray-400""></i>
                                Paramétrage
                            </a>

                            <div class=""dropdown-divider""></div>
                            <a class=""dropdown-item"" href=""#"" data-toggle=""modal"" data-target=""#logoutModal"">
                                <i class=""fas fa-sign-out-alt fa-sm fa-fw mr-2 text-gray-400""></i>
                                Se deconnecter
                            </a>
     ");
            WriteLiteral(@"                   </div>
                    </li>

                </ul>

            </nav>
            <!-- End of Topbar -->
            <!-- Begin Page Content -->
            <div class=""container-fluid"">

                <!-- Page Heading -->
                <h1 class=""h3 mb-2 text-gray-800"" style=""font-size:20px;"">Service économique / Ordre des missions</h1>


                <!-- DataTales Example -->
                <div class=""card shadow mb-4"">
                    <div class=""card-header py-3"">
                        <h6 class=""m-2 font-weight-bold text-primary""> Formulaire d'ajout des ordres des missions</h6>
                    </div>
                    <div class=""card-body"">
                        <div class=""table-responsive"" style=""width:1020px"">

");
#nullable restore
#line 81 "C:\Users\MON PC\Desktop\c# et la programmation .net\projet_migration_copie\gestion_ordre_mission\Views\Ordre\Create.cshtml"
                             using (Html.BeginForm("GeneratePDFOrdreMission", "Ordre", FormMethod.Post))
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 83 "C:\Users\MON PC\Desktop\c# et la programmation .net\projet_migration_copie\gestion_ordre_mission\Views\Ordre\Create.cshtml"
                           Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <form class=""form-horizontal"" style=""width:1220px"">
                                    <div class=""card-body"">
                                        <h4 class=""card-title"">Personal Info</h4>

                                        <div class=""form-group row"">
                                            <label for=""fname""
                                                   class=""col-sm-2 text-end control-label col-form-label"">Numéro:</label>
                                            <div class=""col-sm-4"">
                                                <input type=""text"" name=""numero"" class=""form-control"" />
                                            </div>
                                            <label for=""fname""
                                                   class=""col-sm-2 text-end control-label col-form-label""> Nom Ordre:</label>
                                            <div class=""col-sm-4"">
                                                <in");
            WriteLiteral(@"put type=""text"" name=""nom_ordre"" class=""form-control"" />
                                            </div>

                                        </div>
                                        <div class=""form-group row"">
                                            <label for=""fname""
                                                   class=""col-sm-2 text-end control-label col-form-label"">Grade:</label>
                                            <div class=""col-sm-4"">
                                                <input type=""text"" name=""grade"" class=""form-control"" />
                                            </div>
                                            <label for=""fname""
                                                   class=""col-sm-2 text-end control-label col-form-label"">Echelon:</label>
                                            <div class=""col-sm-4"">
                                                <input type=""text"" name=""echlon"" class=""form-control"" />

                   ");
            WriteLiteral(@"                         </div>

                                        </div>

                                        <div class=""form-group row"">
                                            <label for=""email1""
                                                   class=""col-sm-2 text-end control-label col-form-label"">Objet de depot:</label>
                                            <div class=""col-sm-6"">
                                                <input type=""text"" name=""objet"" class=""form-control"" />

                                            </div>
                                            <div class=""col-sm-4"">

                                            </div>
                                        </div>
                                        <div class=""form-group row"">
                                            <label for=""fname""
                                                   class=""col-sm-2 text-end control-label col-form-label"">Date Départ:</label>
              ");
            WriteLiteral(@"                              <div class=""col-sm-4"">
                                                <div class=""input-group"">
                                                    <input type=""date"" name=""date_depart"" class=""form-control"" />

                                                    <div class=""input-group-append"">
                                                        <span class=""input-group-text h-100""><i class=""fa fa-calendar""></i></span>
                                                    </div>
                                                </div>
                                            </div>
                                            <label for=""fname""
                                                   class=""col-sm-2 text-end control-label col-form-label"">Date de retour:</label>
                                            <div class=""col-sm-4"">
                                                <div class=""input-group"">
                                                    <i");
            WriteLiteral(@"nput type=""date"" name=""date_retour"" class=""form-control"" />

                                                    <div class=""input-group-append"">
                                                        <span class=""input-group-text h-100""><i class=""fa fa-calendar""></i></span>
                                                    </div>
                                                </div>
                                            </div>

                                        </div>

                                        <div class=""form-group row"">
                                            <label for=""fname""
                                                   class=""col-sm-2 text-end control-label col-form-label"">Heure Départ:</label>
                                            <div class=""col-sm-4"">
                                                <div class=""input-group"">
                                                    <input type=""text"" name=""heure_depart"" class=""form-control"" />
");
            WriteLiteral(@"

                                                </div>
                                            </div>
                                            <label for=""fname""
                                                   class=""col-sm-2 text-end control-label col-form-label"">Heure Retour:</label>
                                            <div class=""col-sm-4"">
                                                <div class=""input-group"">
                                                    <input type=""text"" name=""heure_retour"" class=""form-control"" />


                                                </div>
                                            </div>

                                        </div>
                                        <div class=""form-group row"">
                                            <label class=""col-sm-2 text-end control-label col-form-label"">Moyen de Transport :</label>
                                            <div class=""col-sm-6"">
                         ");
            WriteLiteral(@"                       <input type=""text"" name=""moyen"" class=""form-control"" />

                                            </div>
                                            <div class=""col-sm-4"">

                                            </div>
                                        </div>
                                        <div class=""form-group row"">
                                            <label for=""fname""
                                                   class=""col-sm-2 text-end control-label col-form-label"">Matricule:</label>
                                            <div class=""col-sm-4"">
                                                <input type=""text"" name=""matricule"" class=""form-control"" />

                                            </div>
                                            <label class=""col-sm-2 text-end control-label col-form-label"">Nb. Chev:</label>
                                            <div class=""col-sm-4"">
                                    ");
            WriteLiteral(@"            <input type=""text"" name=""nbr_cheuveux"" class=""form-control"" />

                                            </div>

                                        </div>
                                        <div class=""form-group row"">

                                            <label class=""col-sm-2 text-end control-label col-form-label"">Deplacement :</label>
                                            <div class=""col-sm-6"">

                                                <select name=""dep"" class=""select2 form-select shadow-none""
                                                        style=""width: 100%; height:36px;"">
                                                    <option> select ville</option>

");
#nullable restore
#line 207 "C:\Users\MON PC\Desktop\c# et la programmation .net\projet_migration_copie\gestion_ordre_mission\Views\Ordre\Create.cshtml"
                                                     foreach (var item in Model)
                                                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <option");
            BeginWriteAttribute("value", " value=\"", 11715, "\"", 11745, 1);
#nullable restore
#line 210 "C:\Users\MON PC\Desktop\c# et la programmation .net\projet_migration_copie\gestion_ordre_mission\Views\Ordre\Create.cshtml"
WriteAttributeValue("", 11723, item.trajet.id_trajet, 11723, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> ");
#nullable restore
#line 210 "C:\Users\MON PC\Desktop\c# et la programmation .net\projet_migration_copie\gestion_ordre_mission\Views\Ordre\Create.cshtml"
                                                                                           Write(Html.DisplayFor(ModelItem => item.trajet.villeArrivee));

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 211 "C:\Users\MON PC\Desktop\c# et la programmation .net\projet_migration_copie\gestion_ordre_mission\Views\Ordre\Create.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                </select>
                                            </div>

                                        </div>
                                        <div class=""form-group row"">

                                            <label class=""col-sm-2 text-end control-label col-form-label"">Peronnel :</label>
                                            <div class=""col-sm-6"">

                                                <select name=""personnelle"" class=""select2 form-select shadow-none""
                                                        style=""width: 100%; height:36px;"">
                                                    <option> Select personnel</option>

");
#nullable restore
#line 225 "C:\Users\MON PC\Desktop\c# et la programmation .net\projet_migration_copie\gestion_ordre_mission\Views\Ordre\Create.cshtml"
                                                     foreach (var item in Model)
                                                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <option");
            BeginWriteAttribute("value", " value=\"", 12798, "\"", 12827, 1);
#nullable restore
#line 228 "C:\Users\MON PC\Desktop\c# et la programmation .net\projet_migration_copie\gestion_ordre_mission\Views\Ordre\Create.cshtml"
WriteAttributeValue("", 12806, item.personel.IdPers, 12806, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> ");
#nullable restore
#line 228 "C:\Users\MON PC\Desktop\c# et la programmation .net\projet_migration_copie\gestion_ordre_mission\Views\Ordre\Create.cshtml"
                                                                                          Write(Html.DisplayFor(ModelItem => item.personel.Nom));

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 229 "C:\Users\MON PC\Desktop\c# et la programmation .net\projet_migration_copie\gestion_ordre_mission\Views\Ordre\Create.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                </select>
                                            </div>

                                        </div>
                                    </div>
                                    <div class=""border-top"">
                                        <div class=""card-body"">
                                            <input type=""submit"" value=""Enregistrer"" class=""btn btn-primary"" />
                                            <button class=""btn btn-primary"">
                                                <a style=""text-decoration:none;color:white;""");
            BeginWriteAttribute("href", " href=\"", 13559, "\"", 13610, 1);
#nullable restore
#line 239 "C:\Users\MON PC\Desktop\c# et la programmation .net\projet_migration_copie\gestion_ordre_mission\Views\Ordre\Create.cshtml"
WriteAttributeValue("", 13566, Url.Action("ModifierOrdreMission", "Ordre"), 13566, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                                    Modifier
                                                </a>
                                            </button>
                                        </div>
                                    </div>
                                </form>
");
#nullable restore
#line 246 "C:\Users\MON PC\Desktop\c# et la programmation .net\projet_migration_copie\gestion_ordre_mission\Views\Ordre\Create.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>
                    </div>
                </div>
                <div>
                    <a href=""/Ordre/Index"">Retourner à la liste</a>
                </div>
            </div>
            <!-- /.container-fluid -->

        </div>
        <!-- End of Main Content -->
        <!-- Footer -->
        <footer class=""sticky-footer bg-white"">
            <div class=""container my-auto"">
                <div class=""copyright text-center my-auto"">
                    <span>Copyright &copy; Your Website 2020</span>
                </div>
            </div>
        </footer>
        <!-- End of Footer -->

    </div>
    <!-- End of Content Wrapper -->

</div>
<!-- End of Page Wrapper -->
<!-- Scroll to Top Button-->
<a class=""scroll-to-top rounded"" href=""#page-top"">
    <i class=""fas fa-angle-up""></i>
</a>

<!-- Logout Modal-->
<div class=""modal fade"" id=""logoutModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel""
     aria-hidden");
            WriteLiteral(@"=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">
                    Prêt à partir?
                </h5>
                <button class=""close"" type=""button"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">×</span>
                </button>
            </div>
            <div class=""modal-body"">Sélectionnez ""Déconnexion"" ci-dessous si vous êtes prêt à mettre fin à votre session en cours.</div>
            <div class=""modal-footer"">
                <button class=""btn btn-secondary"" type=""button"" data-dismiss=""modal"">Annuler</button>
                <a class=""btn btn-primary"" href=""/Home/login"">Déconnexion</a>
            </div>
        </div>
    </div>
</div>
<!-- Bootstrap core JavaScript-->
<script src=""../Scripts/vendor/jquery/jquery.min.js""></script>
<script src=""../Scripts/vendor/bootstrap/js/bootstrap.");
            WriteLiteral(@"bundle.min.js""></script>

<!-- Core plugin JavaScript-->
<script src=""../Scripts/vendor/jquery-easing/jquery.easing.min.js""></script>

<!-- Custom scripts for all pages-->
<script src=""../Scripts/sb-admin-2.min.js""></script>



<script>
    //***********************************//
    // For select 2
    //***********************************//
    $("".select2"").select2();

    /*colorpicker*/
    $('.demo').each(function () {
        //
        // Dear reader, it's actually very easy to initialize MiniColors. For example:
        //
        //  $(selector).minicolors();
        //
        // The way I've done it below is just for the demo, so don't get confused
        // by it. Also, data- attributes aren't supported at this time...they're
        // only used for this demo.
        //
        $(this).minicolors({
            control: $(this).attr('data-control') || 'hue',
            position: $(this).attr('data-position') || 'bottom left',

            change: function (value,");
            WriteLiteral(@" opacity) {
                if (!value) return;
                if (opacity) value += ', ' + opacity;
                if (typeof console === 'object') {
                    console.log(value);
                }
            },
            theme: 'bootstrap'
        });

    });
    /*datwpicker*/
    jQuery('.mydatepicker').datepicker();
    jQuery('#datepicker-autoclose').datepicker({
        autoclose: true,
        todayHighlight: true
    });
    var quill = new Quill('#editor', {
        theme: 'snow'
    });

</script>

<!-- Bootstrap core JavaScript-->
<script src=""../Scripts/vendor/jquery/jquery.min.js""></script>
<script src=""../Scripts/vendor/bootstrap/js/bootstrap.bundle.min.js""></script>





");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<gestion_ordre_mission.Models.OrdreMission>> Html { get; private set; }
    }
}
#pragma warning restore 1591
