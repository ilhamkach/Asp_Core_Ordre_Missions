#pragma checksum "C:\Users\MON PC\Desktop\c# et la programmation .net\projet_migration_copie\gestion_ordre_mission\Views\Parametrage\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "78e1fdb5d61c9fbc499e14f14e3c4807ee4af08c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Parametrage_Index), @"mvc.1.0.view", @"/Views/Parametrage/Index.cshtml")]
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
#line 5 "C:\Users\MON PC\Desktop\c# et la programmation .net\projet_migration_copie\gestion_ordre_mission\Views\Parametrage\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78e1fdb5d61c9fbc499e14f14e3c4807ee4af08c", @"/Views/Parametrage/Index.cshtml")]
    public class Views_Parametrage_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<gestion_ordre_mission.Models.Parametre_image>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dropdown-item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Parametrage/Index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\MON PC\Desktop\c# et la programmation .net\projet_migration_copie\gestion_ordre_mission\Views\Parametrage\Index.cshtml"
  
    Layout = "~/Views/Shared/MenuLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<meta name=\"viewport\" content=\"width=device-width\" />\r\n<title>Index</title>\r\n<script");
            BeginWriteAttribute("src", " src=\"", 231, "\"", 283, 1);
#nullable restore
#line 9 "C:\Users\MON PC\Desktop\c# et la programmation .net\projet_migration_copie\gestion_ordre_mission\Views\Parametrage\Index.cshtml"
WriteAttributeValue("", 237, Url.Content("~/Scripts/jquery-1.10.2.min.js"), 237, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" type=""text/javascript""></script>
<script type=""text/javascript"">

    $(document).ready(function () {

        $('#Apply').prop('disabled', true);
        $(""#Resume"").change(function () {

            // Get uploaded file extension
            var extension = $(this).val().split('.').pop().toLowerCase();
            // Create array with the files extensions that we wish to upload
            var validFileExtensions = ['doc', 'docx', 'pdf'];
            //Check file extension in the array.if -1 that means the file extension is not in the list.
            if ($.inArray(extension, validFileExtensions) == -1) {
                alert(""Sorry!! Upload only 'doc', 'docx', 'pdf' file"")
                // Clear fileuload control selected file
                $(this).replaceWith($(this).val('').clone(true));
                //Disable Submit Button
                $('#Apply').prop('disabled', true);
            }
            else {
                // Check and restrict the file size to 128 KB.
  ");
            WriteLiteral(@"              if ($(this).get(0).files[0].size > (131072)) {
                    alert(""Sorry!! Max allowed file size is 128 kb"");
                    // Clear fileuload control selected file
                    $(this).replaceWith($(this).val('').clone(true));
                    //Disable Submit Button
                    $('#Apply').prop('disabled', true);
                }
                else {
                    //Enable Submit Button
                    $('#Apply').prop('disabled', false);
                }
            }
        });


        $(""#Apply"").click(function () {
            if ($(""#FirstName"").val() = null || $(""#LastName"").val() || $(""#Skills"").val() || $(""#EmailID"").val() || $(""#ContactNo"").val() || $(""#Resume"").val()) {
                alert(""Please fill out required fields(*)"");
                return false;
            }
            return true;
        });
    });
</script>
<!-- Page Wrapper -->
<div id=""wrapper"">

    <!-- Sidebar -->
    <!-- End of Side");
            WriteLiteral(@"bar -->
    <!-- Content Wrapper -->
    <div id=""content-wrapper"" class=""d-flex flex-column"">

        <!-- Main Content -->
        <div id=""content"" style=""width:1230px"">

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
                           data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                            <i class=""fas fa-se");
            WriteLiteral(@"arch fa-fw""></i>
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
                                        </button>
                                    </div>
          ");
            WriteLiteral(@"                      </div>
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
#line 109 "C:\Users\MON PC\Desktop\c# et la programmation .net\projet_migration_copie\gestion_ordre_mission\Views\Parametrage\Index.cshtml"
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

                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "78e1fdb5d61c9fbc499e14f14e3c4807ee4af08c10178", async() => {
                WriteLiteral("\r\n                                <i class=\"fas fa-cogs fa-sm fa-fw mr-2 text-gray-400\"></i>\r\n                                Paramétrage\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

                            <div class=""dropdown-divider""></div>
                            <a class=""dropdown-item"" href=""#"" data-toggle=""modal"" data-target=""#logoutModal"">
                                <i class=""fas fa-sign-out-alt fa-sm fa-fw mr-2 text-gray-400""></i>
                                Se deconnecter
                            </a>
                        </div>
                    </li>

                </ul>

            </nav>
            <!-- End of Topbar -->
            <!-- Begin Page Content -->
            <div class=""container-fluid"">

                <!-- Page Heading -->
                <h1 class=""h3 mb-2 text-gray-800"" style=""font-size:20px;"">Service économique / modification du paramétre de fiche d'ordre mission</h1>


                <!-- DataTales Example -->
                <div class=""card shadow mb-4"">
                    <div class=""card-header py-3"">
                        <h6 class=""m-2 font-weight-bold text-primary""> Formulaire de modificat");
            WriteLiteral("ion du paramétre de fiche d\'ordre mission</h6>\r\n                    </div>\r\n                    <div class=\"card-body\">\r\n                        <div class=\"table-responsive\" style=\"width:1020px\">\r\n\r\n");
#nullable restore
#line 149 "C:\Users\MON PC\Desktop\c# et la programmation .net\projet_migration_copie\gestion_ordre_mission\Views\Parametrage\Index.cshtml"
                             using (Html.BeginForm("Index", "Parametrage", FormMethod.Post, new { enctype = "multipart/form-data" }))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <br />\r\n");
            WriteLiteral(@"                                <div class=""form-group"">
                                    <label for=""fname"" style=""color:blue""
                                           class=""col-sm-3 text-end control-label col-form-label"">modifier l'en tête de page:</label>
");
            WriteLiteral("                                    <div class=\"editor-field\">\r\n                                        ");
#nullable restore
#line 178 "C:\Users\MON PC\Desktop\c# et la programmation .net\projet_migration_copie\gestion_ordre_mission\Views\Parametrage\Index.cshtml"
                                   Write(Html.TextBoxFor(m => m.header, new { type = "file" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        <br /><br />
                                    </div>
                                    <label for=""fname"" style=""color:blue""
                                           class=""col-sm-3 text-end control-label col-form-label"">modifier le bas de la page</label>
");
            WriteLiteral("                                    <div class=\"editor-field\">\r\n                                        ");
#nullable restore
#line 185 "C:\Users\MON PC\Desktop\c# et la programmation .net\projet_migration_copie\gestion_ordre_mission\Views\Parametrage\Index.cshtml"
                                   Write(Html.TextBoxFor(m => m.footer, new { type = "file" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        <br /><br />
                                    </div>

                                    <label for=""fname"" style=""color:blue""
                                           class=""col-sm-5 text-end control-label col-form-label"">modifier l'arrière plan de la page</label>
");
            WriteLiteral("                                    <div class=\"editor-field\">\r\n                                        ");
#nullable restore
#line 193 "C:\Users\MON PC\Desktop\c# et la programmation .net\projet_migration_copie\gestion_ordre_mission\Views\Parametrage\Index.cshtml"
                                   Write(Html.TextBoxFor(m => m.background, new { type = "file" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        <br /><br />
                                    </div>

                                    <input type=""submit"" id=""Apply"" value=""Appliquer"" class=""btn btn-primary btn-lg"" />




                                </div>
");
#nullable restore
#line 203 "C:\Users\MON PC\Desktop\c# et la programmation .net\projet_migration_copie\gestion_ordre_mission\Views\Parametrage\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n\r\n");
#nullable restore
#line 206 "C:\Users\MON PC\Desktop\c# et la programmation .net\projet_migration_copie\gestion_ordre_mission\Views\Parametrage\Index.cshtml"
                         if (@ViewBag.messageSucces != null)
                        {


#line default
#line hidden
#nullable disable
            WriteLiteral("                            <script type=\"text/javascript\">\r\n                                            window.onload = function () {\r\n                                                alert(\'");
#nullable restore
#line 211 "C:\Users\MON PC\Desktop\c# et la programmation .net\projet_migration_copie\gestion_ordre_mission\Views\Parametrage\Index.cshtml"
                                                  Write(ViewBag.messageSucces);

#line default
#line hidden
#nullable disable
            WriteLiteral("\');\r\n                                            };\r\n\r\n\r\n\r\n                            </script>\r\n");
#nullable restore
#line 217 "C:\Users\MON PC\Desktop\c# et la programmation .net\projet_migration_copie\gestion_ordre_mission\Views\Parametrage\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                    </div>
                </div>
            </div>

        </div>
        <!-- /.container-fluid -->

    </div>
    <!-- End of Main Content -->


</div>
<!-- End of Content Wrapper -->
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
                <h5 class=""modal-title"" id=""exampleModalLabel"">Ready to Leave?</h5>
                <button class=""close"" type=""button"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">×</span>
                </button>
            </div>
            <div class=""modal-body"">Select ""Logout"" below if you are ready to end yo");
            WriteLiteral(@"ur current session.</div>
            <div class=""modal-footer"">
                <button class=""btn btn-secondary"" type=""button"" data-dismiss=""modal"">Cancel</button>
                <a class=""btn btn-primary"" href=""login.html"">Logout</a>
            </div>
        </div>
    </div>
</div>
<!-- Bootstrap core JavaScript-->
<script src=""../Scripts/vendor/jquery/jquery.min.js""></script>
<script src=""../Scripts/vendor/bootstrap/js/bootstrap.bundle.min.js""></script>

<!-- Core plugin JavaScript-->
<script src=""../Scripts/vendor/jquery-easing/jquery.easing.min.js""></script>

<!-- Custom scripts for all pages-->
<script src=""../Scripts/sb-admin-2.min.js""></script>



<!-- Scripts for form template-->
<!-- All Jquery -->
<!-- ============================================================== -->
<script src=""../../assets/libs/jquery/dist/jquery.min.js""></script>
<!-- Bootstrap tether Core JavaScript -->
<script src=""../../assets/libs/bootstrap/dist/js/bootstrap.bundle.min.js""></script>
<!-- slim");
            WriteLiteral(@"scrollbar scrollbar JavaScript -->
<script src=""../../assets/libs/perfect-scrollbar/dist/perfect-scrollbar.jquery.min.js""></script>
<script src=""../../assets/extra-libs/sparkline/sparkline.js""></script>
<!--Wave Effects -->
<script src=""../../dist/js/waves.js""></script>
<!--Menu sidebar -->
<script src=""../../dist/js/sidebarmenu.js""></script>
<!--Custom JavaScript -->
<script src=""../../dist/js/custom.min.js""></script>
<!-- This Page JS -->
<script src=""../Content/assets/libs/inputmask/dist/min/jquery.inputmask.bundle.min.js""></script>
<script src=""../Content/dist/js/pages/mask/mask.init.js""></script>
<script src=""../Content/assets/libs/select2/dist/js/select2.full.min.js""></script>
<script src=""../Content/assets/libs/select2/dist/js/select2.min.js""></script>
<script src=""../Content/assets/libs/jquery-asColor/dist/jquery-asColor.min.js""></script>
<script src=""../Content/assets/libs/jquery-asGradient/dist/jquery-asGradient.js""></script>
<script src=""../Content/assets/libs/jquery-asColorPicker/d");
            WriteLiteral(@"ist/jquery-asColorPicker.min.js""></script>
<script src=""../Content/assets/libs/jquery-minicolors/jquery.minicolors.min.js""></script>
<script src=""../Content/assets/libs/bootstrap-datepicker/dist/js/bootstrap-datepicker.min.js""></script>
<script src=""../Content/assets/libs/quill/dist/quill.min.js""></script>
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
                         ");
            WriteLiteral(@"   // by it. Also, data- attributes aren't supported at this time...they're
                            // only used for this demo.
                            //
                            $(this).minicolors({
                                control: $(this).attr('data-control') || 'hue',
                                position: $(this).attr('data-position') || 'bottom left',

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
                jQuery('#datep");
            WriteLiteral(@"icker-autoclose').datepicker({
                            autoclose: true,
                    todayHighlight: true
                });
                var quill = new Quill('#editor', {
                            theme: 'snow'
                });

</script>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<gestion_ordre_mission.Models.Parametre_image> Html { get; private set; }
    }
}
#pragma warning restore 1591
