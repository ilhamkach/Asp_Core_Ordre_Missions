#pragma checksum "C:\Users\MON PC\Desktop\c# et la programmation .net\projet_migration_copie\gestion_ordre_mission\Views\Ordre\choixKilometrage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "234d0b8117b0cab3bd0287c1fae0832bfb7c5b37"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ordre_choixKilometrage), @"mvc.1.0.view", @"/Views/Ordre/choixKilometrage.cshtml")]
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
#line 4 "C:\Users\MON PC\Desktop\c# et la programmation .net\projet_migration_copie\gestion_ordre_mission\Views\Ordre\choixKilometrage.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"234d0b8117b0cab3bd0287c1fae0832bfb7c5b37", @"/Views/Ordre/choixKilometrage.cshtml")]
    public class Views_Ordre_choixKilometrage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<gestion_ordre_mission.Models.OrdreMission>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\MON PC\Desktop\c# et la programmation .net\projet_migration_copie\gestion_ordre_mission\Views\Ordre\choixKilometrage.cshtml"
   Layout = "~/Views/Shared/MenuLayout.cshtml"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Page Wrapper -->
<div id=""wrapper"">

    <!-- Sidebar -->
    <!-- End of Sidebar -->
    <!-- Content Wrapper -->
    <div id=""content-wrapper"" class=""d-flex flex-column"">

        <!-- Main Content -->
        <div id=""content"" style=""width:1220px"">

            <!-- Topbar -->
            <nav class=""navbar navbar-expand navbar-light bg-white topbar mb-4 static-top shadow"">

                <!-- Sidebar Toggle (Topbar) -->
                <button id=""sidebarToggleTop"" class=""btn btn-link d-md-none rounded-circle mr-3"">
                    <i class=""fa fa-bars""></i>
                </button>



                <!-- Topbar Navbar -->
                <ul class=""navbar-nav ml-auto"">

                    <!-- Nav Item - Search Dropdown (Visible Only XS) -->
                    <li class=""nav-item dropdown no-arrow d-sm-none"">
                        <a class=""nav-link dropdown-toggle"" href=""#"" id=""searchDropdown"" role=""button""
                           data-toggle=""dropdown"" a");
            WriteLiteral(@"ria-haspopup=""true"" aria-expanded=""false"">
                            <i class=""fas fa-search fa-fw""></i>
                        </a>
                        <!-- Dropdown - Messages -->
                        <div class=""dropdown-menu dropdown-menu-right p-3 shadow animated--grow-in""
                             aria-labelledby=""searchDropdown"">
                            <form class=""form-inline mr-auto w-100 navbar-search"">
                                <div class=""input-group"">
                                    <input type=""text"" class=""form-control bg-light border-0 small""
                                           placeholder=""Search for..."" aria-label=""Search""
                                           aria-describedby=""basic-addon2"">
                                    <div class=""input-group-append"">
                                        <button class=""btn btn-primary"" type=""button"">
                                            <i class=""fas fa-search fa-sm""></i>
              ");
            WriteLiteral(@"                          </button>
                                    </div>
                                </div>
                            </form>
                        </div>
                    </li>





                    <div class=""topbar-divider d-none d-sm-block""></div>

                    <!-- Nav Item - User Information -->
                    <li class=""nav-item dropdown no-arrow"">
                        <a class=""nav-link dropdown-toggle"" href=""#"" id=""userDropdown"" role=""button""
                           data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                            <span class=""mr-2 d-none d-lg-inline text-gray-600 small"">");
#nullable restore
#line 64 "C:\Users\MON PC\Desktop\c# et la programmation .net\projet_migration_copie\gestion_ordre_mission\Views\Ordre\choixKilometrage.cshtml"
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
                                <i class=""fas fa-list fa-sm fa-fw mr-2 text-gray-400""></i>
                                Paramétrage
                            </a>
                            <div class=""dropdown-divider""></div>
                            <a class=""dropdown-item"" href=""#"" data-toggle=""modal"" data-target=""#logoutModal"">
                                <i class=""fas fa-sign-out-alt fa-sm fa-fw mr-2 text-gray-400""></i>
                                Se déconnecter
                            </a>
       ");
            WriteLiteral(@"                 </div>
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
                        <h6 class=""m-2 font-weight-bold text-primary""> Filtrer les ordres de mission</h6>
                    </div>
                    <div class=""card-body"">
                        <div class=""table-responsive"">
                            <form action=""Kilo"" method=""post"" class=""form-horizontal"" style=""width:1020px"">
                                <div class=""card-body"">
                                    <h4 class=""card-title"">Choisir l'ordre de mission à traite");
            WriteLiteral(@"r selon le nom personnel et le mois :</h4>

                                    <br /><br />
                                    <div class=""form-group row"">
                                        <label class=""col-sm-2 text-end control-label col-form-label"">Nom Personnel:</label>
                                        <div class=""col-sm-6"">

                                            <select name=""NomPersonel"" id=""NomPersonel"" class=""select2 form-select shadow-none""
                                                    style=""width: 100%; height:36px;"">
                                                <option>Select le personnel</option>
");
#nullable restore
#line 114 "C:\Users\MON PC\Desktop\c# et la programmation .net\projet_migration_copie\gestion_ordre_mission\Views\Ordre\choixKilometrage.cshtml"
                                                 foreach (var item in Model)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <option");
            BeginWriteAttribute("value", " value=\"", 5839, "\"", 5865, 1);
#nullable restore
#line 116 "C:\Users\MON PC\Desktop\c# et la programmation .net\projet_migration_copie\gestion_ordre_mission\Views\Ordre\choixKilometrage.cshtml"
WriteAttributeValue("", 5847, item.personel.Nom, 5847, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> ");
#nullable restore
#line 116 "C:\Users\MON PC\Desktop\c# et la programmation .net\projet_migration_copie\gestion_ordre_mission\Views\Ordre\choixKilometrage.cshtml"
                                                                                   Write(Html.DisplayFor(ModelItem => item.personel.Nom));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 116 "C:\Users\MON PC\Desktop\c# et la programmation .net\projet_migration_copie\gestion_ordre_mission\Views\Ordre\choixKilometrage.cshtml"
                                                                                                                                    Write(Html.DisplayFor(ModelItem => item.personel.Prenom));

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 117 "C:\Users\MON PC\Desktop\c# et la programmation .net\projet_migration_copie\gestion_ordre_mission\Views\Ordre\choixKilometrage.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            </select>
                                        </div>
                                        <div class=""col-sm-4"">

                                        </div>
                                    </div>

                                    <div class=""form-group row"">
                                        <label class=""col-sm-2 text-end control-label col-form-label"">L'année:</label>
                                        <div class=""col-sm-6"">

                                            <select name=""annee"" class=""select2 form-select shadow-none""
                                                    style=""width: 100%; height:36px;"">
                                                <option>Select l'anneé</option>
");
#nullable restore
#line 132 "C:\Users\MON PC\Desktop\c# et la programmation .net\projet_migration_copie\gestion_ordre_mission\Views\Ordre\choixKilometrage.cshtml"
                                                 foreach (var item in Model)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <option");
            BeginWriteAttribute("value", " value=\"", 7008, "\"", 7037, 1);
#nullable restore
#line 134 "C:\Users\MON PC\Desktop\c# et la programmation .net\projet_migration_copie\gestion_ordre_mission\Views\Ordre\choixKilometrage.cshtml"
WriteAttributeValue("", 7016, item.dateDepart.Year, 7016, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> ");
#nullable restore
#line 134 "C:\Users\MON PC\Desktop\c# et la programmation .net\projet_migration_copie\gestion_ordre_mission\Views\Ordre\choixKilometrage.cshtml"
                                                                                      Write(Html.DisplayFor(ModelItem => item.dateDepart.Year));

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 135 "C:\Users\MON PC\Desktop\c# et la programmation .net\projet_migration_copie\gestion_ordre_mission\Views\Ordre\choixKilometrage.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            </select>
                                        </div>
                                        <div class=""col-sm-4"">

                                        </div>
                                    </div>
                                    <div class=""form-group row"">

                                        <label class=""col-sm-2 text-end control-label col-form-label"">Mois :</label>
                                        <div class=""col-sm-6"">

                                            <select name=""mois"" class=""select2 form-select shadow-none""
                                                    style=""width: 100%; height:36px;"">
                                                <option>Select le mois </option>

");
#nullable restore
#line 151 "C:\Users\MON PC\Desktop\c# et la programmation .net\projet_migration_copie\gestion_ordre_mission\Views\Ordre\choixKilometrage.cshtml"
                                                 foreach (var item in Model)
                                                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <option");
            BeginWriteAttribute("value", " value=\"", 8133, "\"", 8163, 1);
#nullable restore
#line 154 "C:\Users\MON PC\Desktop\c# et la programmation .net\projet_migration_copie\gestion_ordre_mission\Views\Ordre\choixKilometrage.cshtml"
WriteAttributeValue("", 8141, item.dateDepart.Month, 8141, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> ");
#nullable restore
#line 154 "C:\Users\MON PC\Desktop\c# et la programmation .net\projet_migration_copie\gestion_ordre_mission\Views\Ordre\choixKilometrage.cshtml"
                                                                                       Write(Html.DisplayFor(ModelItem => item.dateDepart.Month));

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 155 "C:\Users\MON PC\Desktop\c# et la programmation .net\projet_migration_copie\gestion_ordre_mission\Views\Ordre\choixKilometrage.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            </select>
                                        </div>

                                    </div>
                                </div>
                                <div class=""border-top"">
                                    <div class=""card-body"" style=""margin-left:400px; "">

                                        <button type=""submit"" class=""btn btn-info btn-lg"">indimnite Kilometrage</button>
                                    </div>

                                </div>
                            </form>


                        </div>
                    </div>
                </div>

            </div>
            <!-- /.container-fluid -->

        </div>
        <!-- End of Main Content -->
        <!-- Footer -->
        <footer class=""sticky-footer bg-white"">
            <div class=""container my-auto"">
                <div class=""copyright text-center my-auto"">
                    <span>Copyright &copy; Your Website");
            WriteLiteral(@" 2020</span>
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
     aria-hidden=""true"">
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
            <div class=""modal-body"">Sélectionnez ""Déconnexion"" ci-dessous si vous êtes prêt à mett");
            WriteLiteral(@"re fin à votre session en cours.</div>
            <div class=""modal-footer"">
                <button class=""btn btn-secondary"" type=""button"" data-dismiss=""modal"">Annuler</button>
                <a class=""btn btn-primary"" href=""/Home/login"">Déconnexion</a>
            </div>
        </div>
    </div>
</div>

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
            position: $(thi");
            WriteLiteral(@"s).attr('data-position') || 'bottom left',

            change: function (value, opacity) {
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
