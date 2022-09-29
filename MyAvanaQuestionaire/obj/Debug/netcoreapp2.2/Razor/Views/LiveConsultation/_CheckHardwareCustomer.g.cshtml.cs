#pragma checksum "D:\Work2022\My Avana\MyavanaAdminV2\MyAvanaQuestionaire\MyAvanaQuestionaire\Views\LiveConsultation\_CheckHardwareCustomer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "32cbf22a0ee328eb213d1ce5d9bf814e24935d99"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LiveConsultation__CheckHardwareCustomer), @"mvc.1.0.view", @"/Views/LiveConsultation/_CheckHardwareCustomer.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/LiveConsultation/_CheckHardwareCustomer.cshtml", typeof(AspNetCore.Views_LiveConsultation__CheckHardwareCustomer))]
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
#line 1 "D:\Work2022\My Avana\MyavanaAdminV2\MyAvanaQuestionaire\MyAvanaQuestionaire\Views\_ViewImports.cshtml"
using MyAvanaQuestionaire;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32cbf22a0ee328eb213d1ce5d9bf814e24935d99", @"/Views/LiveConsultation/_CheckHardwareCustomer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c37875464b153390b9fdddd027729aa0982cb99", @"/Views/_ViewImports.cshtml")]
    public class Views_LiveConsultation__CheckHardwareCustomer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("msform"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 6508, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "32cbf22a0ee328eb213d1ce5d9bf814e24935d993666", async() => {
                BeginContext(18, 4400, true);
                WriteLiteral(@"
    <fieldset id=""divWelcome"">
        <div class=""fieldset-heading"">
            <h3>Welcome to your virtual consulation!</h3>
        </div>
        <div class=""fieldset-body"">
            <p>
                We're going to walk you through the setup one step at a time. The consultation will not start until you are ready.

            </p>
        </div>
        <input type=""button"" name=""next"" id=""btnWelcomeNext"" class=""next action-button m-auto"" value=""Continue"" />
    </fieldset>
    <fieldset id=""divGrantAccess"">
        <div class=""fieldset-heading"">
            <h3> Grant Myavana required permissions.</h3>
        </div>
        <div class=""fieldset-body"">
            <p class=""mb-0"">
                <i class=""fa fa-rss"" aria-hidden=""true""></i> In order to stream audio and video, we'll need access to your media devices.
            </p>
            <hr>
            <p>
                <i class=""fa fa-check-circle-o"" aria-hidden=""true""></i> Do you give Myavana permissions to use");
                WriteLiteral(@" your camera and microphone?
            </p>
        </div>
        <input type=""button"" name=""previous"" id=""btnGrantBack"" class=""previous action-button back_btn"" onclick=""Back()"" value=""Back"" />
        <input type=""button"" name=""next"" id=""btnGrantNext"" class=""next action-button next_btn"" onclick=""CheckCameraSupport()"" value=""Yes"" />
    </fieldset>
    <fieldset id=""divBestPractices"">
        <div class=""fieldset-heading"">
            <h3>Consultation Best Practices</h3>
        </div>
        <div class=""fieldset-body"">
            <p>
                We are about to walk you through our recommendations to ensure you have the smoothest experience possible.
            </p>
        </div>
        <input type=""button"" name=""next"" id=""btnPracticesNext"" class=""next action-button m-auto"" value=""Continue"" />
    </fieldset>
    <fieldset id=""divUseHeadphones"">
        <div class=""fieldset-body"">
            <p class=""mb-2 circle-icon"">
                <i class=""fa fa-headphones"" aria-hidden=");
                WriteLiteral(@"""true""></i>
            </p>
            <h3 class=""text-white"">Use Headphones</h3>
            <p>
                We suggest using headphones during your consultation to avoid echoing and feedback to achieve the best sound quality.

            </p>
            <p class=""internal-box mb-0"">
                <span><input class=""w-auto"" id=""chkUncheck"" type=""checkbox"" onchange=""CheckStatus(this)"" /> </span>Please confirm you understand by checking this box
                <i class=""d-block"">(may result in echoing if you're not using headphones)</i>
            <p>
        </div>
        <input type=""button"" name=""previous"" id=""btnHeadphoneBack"" class=""previous action-button back_btn"" value=""Back"" />
        <input type=""button"" name=""next"" id=""btnHeadphoneNext"" class=""next action-button next_btn"" value=""Continue"" />
    </fieldset>
    <fieldset id=""divMediaSuccess"">
        <div class=""fieldset-heading"">
            <h3>
                Successfully connected to your media devices!
        ");
                WriteLiteral(@"    </h3>
        </div>
        <div class=""fieldset-body"">
            <p class=""mb-2 circle-icon"">
                <i class=""fa fa-video-camera "" aria-hidden=""true""></i>
                <i class=""fa fa-microphone "" aria-hidden=""true""></i>
            </p>
            <p class=""mb-0"">
                Next we'll configure which camera and microphone you will be using.
            <p>
        </div>
        <input type=""button"" name=""previous"" id=""btnMediaBack"" class=""previous action-button back_btn"" value=""Back"" />
        <input type=""button"" name=""next"" id=""btnMediaNext"" class=""next action-button next_btn"" value=""Continue"" onclick=""SelectCamera()"" />

    </fieldset>
    <fieldset id=""divCameraAccess"">
        <div class=""fieldset-heading"">
            <h3>
                Select a camera
            </h3>
        </div>
        <div class=""fieldset-body"">
            <div class=""select w-100"">
                <p class=""mb-2 circle-icon"">
                    <i class=""fa fa-video-ca");
                WriteLiteral(@"mera"" aria-hidden=""true""></i>
                </p>
                <p class=""mb-2"">Choose the camera you would like to use </p>
                <select id=""videoSource"" class=""input-style"" onchange=""SelectCamera()""></select>
            </div>
            <div id=""local-media-container-id""></div>
");
                EndContext();
                BeginContext(4516, 1905, true);
                WriteLiteral(@"        </div>
        <input type=""button"" name=""previous"" id=""btnCameraBack"" class=""previous action-button back_btn"" value=""Back"" />
        <input type=""button"" name=""next"" id=""btnCameraNext"" class=""next action-button next_btn"" value=""Continue"" onclick=""StopCamera()"" />

    </fieldset>
    <fieldset id=""divMicrophoneAccess"">
        <div class=""fieldset-heading"">
            <h3>
                Select a microphone
            </h3>
        </div>
        <div class=""fieldset-body"">

            <div class=""select w-100"">
                <p class=""mb-2 circle-icon"">
                    <i class=""fa fa-microphone"" aria-hidden=""true""></i>
                </p>
                <p class=""mb-2"">Choose the microphone you would like to use </p>

            </div>

            <div class=""audio-block-1"">
                <div id=""audio-div"" class=""microphone-canvas"">
                    <select id=""audioSource"" class=""input-style mb-3""></select>
                    <p id=""audio-info""></p>
");
                WriteLiteral(@"                    <canvas id=""audio-canvas"" class=""audio_canvas"" width=""458"" height=""164""></canvas>
                </div>
            </div>

            <div class=""select w-100"" style=""display:none"">
                <p>Audio output destination: </p><select id=""audioOutput"" class=""input-style  mb-3""></select>
            </div>
        </div>
        <input type=""button"" name=""previous"" id=""btnMicrophoneBack"" class=""previous action-button back_btn"" value=""Back"" />
        <input type=""button"" name=""next"" id=""btnMicrophoneNext"" class=""next action-button next_btn"" value=""Continue"" onclick=""JoinInterviewCandidate()""/>
    </fieldset>
    <fieldset id=""divJoinInterviewCandidate"">
        <div class=""fieldset-heading"">
            <h3>
                Consultation Started
            </h3>
        </div>
        <div class=""fieldset-body"">
            ");
                EndContext();
                BeginContext(6422, 41, false);
#line 137 "D:\Work2022\My Avana\MyavanaAdminV2\MyAvanaQuestionaire\MyAvanaQuestionaire\Views\LiveConsultation\_CheckHardwareCustomer.cshtml"
       Write(Html.Partial("_JoinCustomerConsultation"));

#line default
#line hidden
                EndContext();
                BeginContext(6463, 38, true);
                WriteLiteral("\r\n        </div>\r\n    </fieldset>\r\n   ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6508, 5694, true);
            WriteLiteral(@"
    <script type=""text/javascript"">
        const Video = Twilio.Video;
        var videoElementTwilio;
        var localVideoTrackCamera;
        var localAudioTrack;
        var ArrayLocalTracks;

        function SelectCamera() {

            if (ArrayLocalTracks != undefined) {
                ArrayLocalTracks.forEach(function (track) {
                    track.stop();
                });
            }
            var videoCameraSelectedDevice = document.querySelector('select#videoSource');

            Video.createLocalTracks({ audio: false, video: { deviceId: videoCameraSelectedDevice.value } }).then(function (localTracks) {

                localTracks.forEach(function (track) {
                    console.log(`local media div`);
                    ArrayLocalTracks = localTracks;
                    const localMediaContainer = document.getElementById('local-media-container-id');
                    localMediaContainer.innerHTML = """";
                    localMediaContainer.ap");
            WriteLiteral(@"pendChild(track.attach());

                    var video = $(""#local-media-div video"");
                    video.attr(""height"", ""120px"");
                });
            });

        }
        function StopCamera() {
            ArrayLocalTracks.forEach(function (track) {
                track.stop();
            });
        }


        function attachSinkIdTwilio(element, sinkId) {
            if (typeof element.sinkId !== 'undefined') {
                element.setSinkId(sinkId)
                    .then(() => {
                        console.log(`Success, audio output device attached: ${sinkId}`);
                    })
                    .catch(error => {
                        let errorMessage = error;
                        if (error.name === 'SecurityError') {
                            errorMessage = `You need to use HTTPS for selecting audio output device: ${error}`;
                        }
                        console.error(errorMessage);
                       ");
            WriteLiteral(@" // Jump back to first output device in the list as it's the default.
                        audioOutputSelect.selectedIndex = 0;
                    });
            } else {
                console.warn('Browser does not support output device selection.');
            }
        }
    </script>
    <script>


        //jQuery time
        var current_fs, next_fs, previous_fs; //fieldsets
        var left, opacity, scale; //fieldset properties which we will animate
        var animating; //flag to prevent quick multi-click glitches

        $("".next"").click(function () {

            if (animating) return false;
            animating = true;

            current_fs = $(this).parent();
            next_fs = $(this).parent().next();

            //activate next step on progressbar using the index of next_fs
            $(""#progressbar li"").eq($(""fieldset"").index(next_fs)).addClass(""active"");

            //show the next fieldset
            next_fs.show();
            //hide the cur");
            WriteLiteral(@"rent fieldset with style
            current_fs.animate({ opacity: 0 }, {
                step: function (now, mx) {
                    //as the opacity of current_fs reduces to 0 - stored in ""now""
                    //1. scale current_fs down to 80%
                    scale = 1 - (1 - now) * 0.2;
                    //2. bring next_fs from the right(50%)
                    left = (now * 50) + ""%"";
                    //3. increase opacity of next_fs to 1 as it moves in
                    opacity = 1 - now;
                    current_fs.css({
                        'transform': 'scale(' + scale + ')',
                        'position': 'absolute'
                    });
                    next_fs.css({ 'left': left, 'opacity': opacity });
                },
                duration: 800,
                complete: function () {
                    current_fs.hide();
                    animating = false;
                },
                //this comes from the custom easing plugin");
            WriteLiteral(@"
                easing: 'easeInOutBack'
            });
        });

        $("".previous"").click(function () {
            if (animating) return false;
            animating = true;

            current_fs = $(this).parent();
            previous_fs = $(this).parent().prev();

            //de-activate current step on progressbar
            $(""#progressbar li"").eq($(""fieldset"").index(current_fs)).removeClass(""active"");

            //show the previous fieldset
            previous_fs.show();
            //hide the current fieldset with style
            current_fs.animate({ opacity: 0 }, {
                step: function (now, mx) {
                    //as the opacity of current_fs reduces to 0 - stored in ""now""
                    //1. scale previous_fs from 80% to 100%
                    scale = 0.8 + (1 - now) * 0.2;
                    //2. take current_fs to the right(50%) - from 0%
                    left = ((1 - now) * 50) + ""%"";
                    //3. increase opacity o");
            WriteLiteral(@"f previous_fs to 1 as it moves in
                    opacity = 1 - now;
                    current_fs.css({ 'left': left });
                    previous_fs.css({ 'transform': 'scale(' + scale + ')', 'opacity': opacity });
                },
                duration: 800,
                complete: function () {
                    current_fs.hide();
                    animating = false;
                },
                //this comes from the custom easing plugin
                easing: 'easeInOutBack'
            });
        });



    </script>
");
            EndContext();
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
