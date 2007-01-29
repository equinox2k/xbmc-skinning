Imports System.Xml.Serialization

<XmlRoot("control")> _
Public Class Control

    'label,fadelabel,image,multiimage,button,radiobutton,selectbutton,togglebutton
    'buttonscroller,spincontrol,spincontrolex,slider,sliderex,progress,listcontrol
    'thumbnailpanel,textbox,rss,visualisation,videowindow,mover,resize

    'label
    'edit
    'videowindow
    'fadelabel
    'button
    'rss
    'ram
    'console
    'togglebutton
    'checkmark
    'radiobutton
    'spincontrol
    'slider
    'sliderex
    'progress
    'image
    'multiimage
    'listcontrol
    'listcontrolex
    'textbox
    'thumbnailpanel
    'selectbutton
    'mover
    'resize
    'buttonscroller
    'spincontrolex

    'label,fadelabel,image,multiimage,button,radiobutton,selectbutton,togglebutton
    'buttonscroller,spincontrol,spincontrolex,slider,sliderex,progress,listcontrol
    'thumbnailpanel,textbox,rss,visualisation,videowindow,mover,resize

    'Added 

    'edit
    'videowindow
    'ram
    'console
    'checkmark
    'listcontrolex


    Private strDescription As String = Nothing
    Private strType As String = Nothing
    Private strID As String = Nothing
    Private strPosX As String = Nothing
    Private strPosY As String = Nothing
    Private strWidth As String = Nothing
    Private strHeight As String = Nothing
    Private strTextSpaceY As String = Nothing
    Private objVisible As Visible = Nothing
    Private objAnimation() As Animation = Nothing
    Private strImageFolderFocus As String = Nothing
    Private strImageFolder As String = Nothing
    Private strTextureFocus As String = Nothing
    Private strTextureNoFocus As String = Nothing
    Private strTextureRadioFocus As String = Nothing
    Private strTextureRadioNoFocus As String = Nothing
    Private strTextureBg As String = Nothing
    Private strTextureLeft As String = Nothing
    Private strTextureLeftFocus As String = Nothing
    Private strTextureRight As String = Nothing
    Private strTextureRightFocus As String = Nothing
    Private strTextureUp As String = Nothing
    Private strTextureUpFocus As String = Nothing
    Private strTextureDown As String = Nothing
    Private strTextureDownFocus As String = Nothing
    Private strAltTextureFocus As String = Nothing
    Private strAltTextureNoFocus As String = Nothing
    Private strUseAltTexture As String = Nothing
    Private strTextureSliderNib As String = Nothing
    Private strTextureSliderNibFocus As String = Nothing
    Private strControlOffsetX As String = Nothing
    Private strControlOffsetY As String = Nothing
    Private strImagePath As String = Nothing
    Private strInfo() As String = Nothing
    Private strTimePerImage As String = Nothing
    Private strFadeTime As String = Nothing
    Private strLoopImage As String = Nothing
    Private strSuffix As String = Nothing
    Private strThumbAlign As String = Nothing
    Private strAlign As String = Nothing
    Private strAlignY As String = Nothing
    Private strTextXOff As String = Nothing
    Private strTextYOff As String = Nothing
    Private strTextXOff2 As String = Nothing
    Private strTextYOff2 As String = Nothing
    Private strTextOffsetX As String = Nothing
    Private strTextOffsetY As String = Nothing
    Private strItemWidth As String = Nothing
    Private strItemHeight As String = Nothing
    Private strThumbPosX As String = Nothing
    Private strThumbPosY As String = Nothing
    Private strThumbWidth As String = Nothing
    Private strThumbHeight As String = Nothing
    Private strTextureWidth As String = Nothing
    Private strTextureHeight As String = Nothing
    Private strItemWidthBig As String = Nothing
    Private strItemHeightBig As String = Nothing
    Private strThumbPosXBig As String = Nothing
    Private strThumbPosYBig As String = Nothing
    Private strThumbWidthBig As String = Nothing
    Private strThumbHeightBig As String = Nothing
    Private strTextureWidthBig As String = Nothing
    Private strTextureHeightBig As String = Nothing
    Private strSpaceBetweenItems As String = Nothing
    Private strSpinPosX As String = Nothing
    Private strSpinPosY As String = Nothing
    Private strSpinWidth As String = Nothing
    Private strSpinHeight As String = Nothing
    Private strSpinColor As String = Nothing
    Private strPulseOnSelect As String = Nothing
    Private strOnClick() As String = Nothing
    Private strOnFocus As String = Nothing
    Private strOnUp As String = Nothing
    Private strOnDown As String = Nothing
    Private strOnLeft As String = Nothing
    Private strOnRight As String = Nothing
    Private strNumButtons As String = Nothing
    Private strButtonGap As String = Nothing
    Private strOrientation As String = Nothing
    Private strDefaultButton As String = Nothing
    Private strMovement As String = Nothing
    Private strAlpha As String = Nothing
    Private strWrapAround As String = Nothing
    Private strSmoothScrolling As String = Nothing
    Private objButtons As Buttons = Nothing
    Private strScroll As String = Nothing
    Private strLabel() As String = Nothing
    Private strNumber As String = Nothing
    Private strColorDiffuse As String = Nothing
    Private strColorKey As String = Nothing
    Private strTexture As String = Nothing
    Private strHasPath As String = Nothing
    Private strFont As String = Nothing
    Private strFont2 As String = Nothing
    Private strTextColor As String = Nothing
    Private strTextColor2 As String = Nothing
    Private strDisabledColor As String = Nothing
    Private strSelectedColor As String = Nothing
    Private strSelectedColor2 As String = Nothing
    Private strShadow As String = Nothing
    Private strShadowColor As String = Nothing
    Private strHeadlineColor As String = Nothing
    Private strTitleColor As String = Nothing
    Private strUrlSet As String = Nothing
    Private strSubType As String = Nothing
    Private strReverse As String = Nothing
    Private strRange As String = Nothing
    Private strAngle As String = Nothing
    Private strAspectRatio As String = Nothing
    Private strWrapMultiLine As String = Nothing
    Private strGfxThumbWidth As String = Nothing
    Private strGfxThumbHeight As String = Nothing
    Private strGfxThumbSpaceX As String = Nothing
    Private strGfxThumbSpaceY As String = Nothing
    Private strGfxThumbDefault As String = Nothing
    Private strBitmaps As String = Nothing
    Private strSpinFont As String = Nothing
    Private strMarkWidth As String = Nothing
    Private strMarkHeight As String = Nothing
    Private strSliderWidth As String = Nothing
    Private strSliderHeight As String = Nothing
    Private strTextureCheckMark As String = Nothing
    Private strTextureCheckMarkNoFocus As String = Nothing
    Private strTextureSliderBar As String = Nothing
    Private strDisposition As String = Nothing
    Private strTitle As String = Nothing
    Private strTagSet As String = Nothing
    Private strLeftTexture As String = Nothing
    Private strMidTexture As String = Nothing
    Private strRightTexture As String = Nothing
    Private strOverlayTexture As String = Nothing
    Private strKeepAspectRatio As String = Nothing
    Private strRandomize As String = Nothing
    Private strRadioWidth As String = Nothing
    Private strRadioHeight As String = Nothing
    Private strRadioPosX As String = Nothing
    Private strRadioPosY As String = Nothing
    Private strInclude() As String = Nothing

    <XmlElement(ElementName:="description", IsNullable:=False)> _
    Public Property Description() As String
        Get
            Return strDescription
        End Get
        Set(ByVal Value As String)
            strDescription = Value
        End Set
    End Property

    <XmlElement(ElementName:="type", IsNullable:=False)> _
    Public Property Type() As String
        Get
            Return strType
        End Get
        Set(ByVal Value As String)
            strType = Value
        End Set
    End Property

    <XmlElement(ElementName:="id", IsNullable:=False)> _
    Public Property ID() As String
        Get
            Return strID
        End Get
        Set(ByVal Value As String)
            strID = Value
        End Set
    End Property

    <XmlElement(ElementName:="posx", IsNullable:=False)> _
    Public Property PosX() As String
        Get
            Return strPosX
        End Get
        Set(ByVal Value As String)
            strPosX = Value
        End Set
    End Property

    <XmlElement(ElementName:="posy", IsNullable:=False)> _
    Public Property PosY() As String
        Get
            Return strPosY
        End Get
        Set(ByVal Value As String)
            strPosY = Value
        End Set
    End Property

    <XmlElement(ElementName:="width", IsNullable:=False)> _
    Public Property Width() As String
        Get
            Return strWidth
        End Get
        Set(ByVal Value As String)
            strWidth = Value
        End Set
    End Property

    <XmlElement(ElementName:="height", IsNullable:=False)> _
    Public Property Height() As String
        Get
            Return strHeight
        End Get
        Set(ByVal Value As String)
            strHeight = Value
        End Set
    End Property

    <XmlElement(ElementName:="textspacey", IsNullable:=False)> _
    Public Property TextSpaceY() As String
        Get
            Return strTextSpaceY
        End Get
        Set(ByVal Value As String)
            strTextSpaceY = Value
        End Set
    End Property

    <XmlElement(ElementName:="visible", IsNullable:=False)> _
    Public Property Visible() As Visible
        Get
            Return objVisible
        End Get
        Set(ByVal Value As Visible)
            objVisible = Value
        End Set
    End Property

    <XmlElement(ElementName:="animation", IsNullable:=False)> _
    Public Property Animation() As Animation()
        Get
            Return objAnimation
        End Get
        Set(ByVal Value As Animation())
            objAnimation = Value
        End Set
    End Property

    <XmlElement(ElementName:="imagefolderfocus", IsNullable:=False)> _
    Public Property ImageFolderFocus() As String
        Get
            Return strImageFolderFocus
        End Get
        Set(ByVal Value As String)
            strImageFolderFocus = Value
        End Set
    End Property

    <XmlElement(ElementName:="imagefolder", IsNullable:=False)> _
    Public Property ImageFolder() As String
        Get
            Return strImageFolder
        End Get
        Set(ByVal Value As String)
            strImageFolder = Value
        End Set
    End Property

    <XmlElement(ElementName:="texturefocus", IsNullable:=False)> _
    Public Property TextureFocus() As String
        Get
            Return strTextureFocus
        End Get
        Set(ByVal Value As String)
            strTextureFocus = Value
        End Set
    End Property

    <XmlElement(ElementName:="texturenofocus", IsNullable:=False)> _
    Public Property TextureNoFocus() As String
        Get
            Return strTextureNoFocus
        End Get
        Set(ByVal Value As String)
            strTextureNoFocus = Value
        End Set
    End Property

    <XmlElement(ElementName:="textureradiofocus", IsNullable:=False)> _
    Public Property TextureRadioFocus() As String
        Get
            Return strTextureRadioFocus
        End Get
        Set(ByVal Value As String)
            strTextureRadioFocus = Value
        End Set
    End Property

    <XmlElement(ElementName:="textureradionofocus", IsNullable:=False)> _
    Public Property TextureRadioNoFocus() As String
        Get
            Return strTextureRadioNoFocus
        End Get
        Set(ByVal Value As String)
            strTextureRadioNoFocus = Value
        End Set
    End Property

    <XmlElement(ElementName:="texturebg", IsNullable:=False)> _
    Public Property TextureBg() As String
        Get
            Return strTextureBg
        End Get
        Set(ByVal Value As String)
            strTextureBg = Value
        End Set
    End Property

    <XmlElement(ElementName:="textureleft", IsNullable:=False)> _
    Public Property TextureLeft() As String
        Get
            Return strTextureLeft
        End Get
        Set(ByVal Value As String)
            strTextureLeft = Value
        End Set
    End Property

    <XmlElement(ElementName:="textureleftfocus", IsNullable:=False)> _
    Public Property TextureLeftFocus() As String
        Get
            Return strTextureLeftFocus
        End Get
        Set(ByVal Value As String)
            strTextureLeftFocus = Value
        End Set
    End Property

    <XmlElement(ElementName:="textureright", IsNullable:=False)> _
    Public Property TextureRight() As String
        Get
            Return strTextureRight
        End Get
        Set(ByVal Value As String)
            strTextureRight = Value
        End Set
    End Property

    <XmlElement(ElementName:="texturerightfocus", IsNullable:=False)> _
    Public Property TextureRightFocus() As String
        Get
            Return strTextureRightFocus
        End Get
        Set(ByVal Value As String)
            strTextureRightFocus = Value
        End Set
    End Property

    <XmlElement(ElementName:="textureup", IsNullable:=False)> _
    Public Property TextureUp() As String
        Get
            Return strTextureUp
        End Get
        Set(ByVal Value As String)
            strTextureUp = Value
        End Set
    End Property

    <XmlElement(ElementName:="textureupfocus", IsNullable:=False)> _
    Public Property TextureUpFocus() As String
        Get
            Return strTextureUpFocus
        End Get
        Set(ByVal Value As String)
            strTextureUpFocus = Value
        End Set
    End Property

    <XmlElement(ElementName:="texturedown", IsNullable:=False)> _
    Public Property TextureDown() As String
        Get
            Return strTextureDown
        End Get
        Set(ByVal Value As String)
            strTextureDown = Value
        End Set
    End Property

    <XmlElement(ElementName:="texturedownfocus", IsNullable:=False)> _
    Public Property TextureDownFocus() As String
        Get
            Return strTextureDownFocus
        End Get
        Set(ByVal Value As String)
            strTextureDownFocus = Value
        End Set
    End Property

    <XmlElement(ElementName:="alttexturefocus", IsNullable:=False)> _
    Public Property AltTextureFocus() As String
        Get
            Return strAltTextureFocus
        End Get
        Set(ByVal Value As String)
            strAltTextureFocus = Value
        End Set
    End Property

    <XmlElement(ElementName:="alttexturenofocus", IsNullable:=False)> _
    Public Property AltTextureNoFocus() As String
        Get
            Return strAltTextureNoFocus
        End Get
        Set(ByVal Value As String)
            strAltTextureNoFocus = Value
        End Set
    End Property

    <XmlElement(ElementName:="usealttexture", IsNullable:=False)> _
    Public Property UseAltTexture() As String
        Get
            Return strUseAltTexture
        End Get
        Set(ByVal Value As String)
            strUseAltTexture = Value
        End Set
    End Property

    <XmlElement(ElementName:="textureslidernib", IsNullable:=False)> _
    Public Property TextureSliderNib() As String
        Get
            Return strTextureSliderNib
        End Get
        Set(ByVal Value As String)
            strTextureSliderNib = Value
        End Set
    End Property

    <XmlElement(ElementName:="textureslidernibfocus", IsNullable:=False)> _
    Public Property TextureSliderNibFocus() As String
        Get
            Return strTextureSliderNibFocus
        End Get
        Set(ByVal Value As String)
            strTextureSliderNibFocus = Value
        End Set
    End Property

    <XmlElement(ElementName:="controloffsetx", IsNullable:=False)> _
    Public Property ControlOffsetX() As String
        Get
            Return strControlOffsetX
        End Get
        Set(ByVal Value As String)
            strControlOffsetX = Value
        End Set
    End Property

    <XmlElement(ElementName:="controloffsety", IsNullable:=False)> _
    Public Property ControlOffsetY() As String
        Get
            Return strControlOffsetY
        End Get
        Set(ByVal Value As String)
            strControlOffsetY = Value
        End Set
    End Property

    <XmlElement(ElementName:="imagepath", IsNullable:=False)> _
    Public Property ImagePath() As String
        Get
            Return strImagePath
        End Get
        Set(ByVal Value As String)
            strImagePath = Value
        End Set
    End Property

    <XmlElement(ElementName:="info", IsNullable:=False)> _
    Public Property Info() As String()
        Get
            Return strInfo
        End Get
        Set(ByVal Value As String())
            strInfo = Value
        End Set
    End Property

    <XmlElement(ElementName:="timeperimage", IsNullable:=False)> _
    Public Property TimePerImage() As String
        Get
            Return strTimePerImage
        End Get
        Set(ByVal Value As String)
            strTimePerImage = Value
        End Set
    End Property

    <XmlElement(ElementName:="fadetime", IsNullable:=False)> _
    Public Property FadeTime() As String
        Get
            Return strFadeTime
        End Get
        Set(ByVal Value As String)
            strFadeTime = Value
        End Set
    End Property

    <XmlElement(ElementName:="loop", IsNullable:=False)> _
    Public Property LoopImage() As String
        Get
            Return strLoopImage
        End Get
        Set(ByVal Value As String)
            strLoopImage = Value
        End Set
    End Property

    <XmlElement(ElementName:="suffix", IsNullable:=False)> _
    Public Property Suffix() As String
        Get
            Return strSuffix
        End Get
        Set(ByVal Value As String)
            strSuffix = Value
        End Set
    End Property

    <XmlElement(ElementName:="thumbalign", IsNullable:=False)> _
    Public Property ThumbAlign() As String
        Get
            Return strThumbAlign
        End Get
        Set(ByVal Value As String)
            strThumbAlign = Value
        End Set
    End Property

    <XmlElement(ElementName:="align", IsNullable:=False)> _
    Public Property Align() As String
        Get
            Return strAlign
        End Get
        Set(ByVal Value As String)
            strAlign = Value
        End Set
    End Property

    <XmlElement(ElementName:="aligny", IsNullable:=False)> _
    Public Property AlignY() As String
        Get
            Return strAlignY
        End Get
        Set(ByVal Value As String)
            strAlignY = Value
        End Set
    End Property

    <XmlElement(ElementName:="textxoff", IsNullable:=False)> _
    Public Property TextXOff() As String
        Get
            Return strTextXOff
        End Get
        Set(ByVal Value As String)
            strTextXOff = Value
        End Set
    End Property

    <XmlElement(ElementName:="textyoff", IsNullable:=False)> _
    Public Property TextYOff() As String
        Get
            Return strTextYOff
        End Get
        Set(ByVal Value As String)
            strTextYOff = Value
        End Set
    End Property

    <XmlElement(ElementName:="textxoff2", IsNullable:=False)> _
    Public Property TextXOff2() As String
        Get
            Return strTextXOff2
        End Get
        Set(ByVal Value As String)
            strTextXOff2 = Value
        End Set
    End Property

    <XmlElement(ElementName:="textyoff2", IsNullable:=False)> _
    Public Property TextYOff2() As String
        Get
            Return strTextYOff2
        End Get
        Set(ByVal Value As String)
            strTextYOff2 = Value
        End Set
    End Property

    <XmlElement(ElementName:="textoffsetx", IsNullable:=False)> _
    Public Property TextOffsetX() As String
        Get
            Return strTextOffsetX
        End Get
        Set(ByVal Value As String)
            strTextOffsetX = Value
        End Set
    End Property

    <XmlElement(ElementName:="textoffsety", IsNullable:=False)> _
    Public Property TextOffsetY() As String
        Get
            Return strTextOffsetY
        End Get
        Set(ByVal Value As String)
            strTextOffsetY = Value
        End Set
    End Property

    <XmlElement(ElementName:="itemwidth", IsNullable:=False)> _
    Public Property ItemWidth() As String
        Get
            Return strItemWidth
        End Get
        Set(ByVal Value As String)
            strItemWidth = Value
        End Set
    End Property

    <XmlElement(ElementName:="itemheight", IsNullable:=False)> _
    Public Property ItemHeight() As String
        Get
            Return strItemHeight
        End Get
        Set(ByVal Value As String)
            strItemHeight = Value
        End Set
    End Property

    <XmlElement(ElementName:="thumbposx", IsNullable:=False)> _
    Public Property ThumbPosX() As String
        Get
            Return strThumbPosX
        End Get
        Set(ByVal Value As String)
            strThumbPosX = Value
        End Set
    End Property

    <XmlElement(ElementName:="thumbposy", IsNullable:=False)> _
    Public Property ThumbPosY() As String
        Get
            Return strThumbPosY
        End Get
        Set(ByVal Value As String)
            strThumbPosY = Value
        End Set
    End Property

    <XmlElement(ElementName:="thumbwidth", IsNullable:=False)> _
    Public Property ThumbWidth() As String
        Get
            Return strThumbWidth
        End Get
        Set(ByVal Value As String)
            strThumbWidth = Value
        End Set
    End Property

    <XmlElement(ElementName:="thumbheight", IsNullable:=False)> _
    Public Property ThumbHeight() As String
        Get
            Return strThumbHeight
        End Get
        Set(ByVal Value As String)
            strThumbHeight = Value
        End Set
    End Property

    <XmlElement(ElementName:="texturewidth", IsNullable:=False)> _
    Public Property TextureWidth() As String
        Get
            Return strTextureWidth
        End Get
        Set(ByVal Value As String)
            strTextureWidth = Value
        End Set
    End Property

    <XmlElement(ElementName:="textureheight", IsNullable:=False)> _
    Public Property TextureHeight() As String
        Get
            Return strTextureHeight
        End Get
        Set(ByVal Value As String)
            strTextureHeight = Value
        End Set
    End Property

    <XmlElement(ElementName:="itemwidthbig", IsNullable:=False)> _
    Public Property ItemWidthBig() As String
        Get
            Return strItemWidthBig
        End Get
        Set(ByVal Value As String)
            strItemWidthBig = Value
        End Set
    End Property

    <XmlElement(ElementName:="itemheightbig", IsNullable:=False)> _
    Public Property ItemHeightBig() As String
        Get
            Return strItemHeightBig
        End Get
        Set(ByVal Value As String)
            strItemHeightBig = Value
        End Set
    End Property

    <XmlElement(ElementName:="thumbposxbig", IsNullable:=False)> _
    Public Property ThumbPosXBig() As String
        Get
            Return strThumbPosXBig
        End Get
        Set(ByVal Value As String)
            strThumbPosXBig = Value
        End Set
    End Property

    <XmlElement(ElementName:="thumbposybig", IsNullable:=False)> _
    Public Property ThumbPosYBig() As String
        Get
            Return strThumbPosYBig
        End Get
        Set(ByVal Value As String)
            strThumbPosY = Value
        End Set
    End Property

    <XmlElement(ElementName:="thumbwidthbig", IsNullable:=False)> _
    Public Property ThumbWidthBig() As String
        Get
            Return strThumbWidthBig
        End Get
        Set(ByVal Value As String)
            strThumbWidthBig = Value
        End Set
    End Property

    <XmlElement(ElementName:="thumbheightbig", IsNullable:=False)> _
    Public Property ThumbHeightBig() As String
        Get
            Return strThumbHeightBig
        End Get
        Set(ByVal Value As String)
            strThumbHeightBig = Value
        End Set
    End Property

    <XmlElement(ElementName:="texturewidthbig", IsNullable:=False)> _
    Public Property TextureWidthBig() As String
        Get
            Return strTextureWidthBig
        End Get
        Set(ByVal Value As String)
            strTextureWidthBig = Value
        End Set
    End Property

    <XmlElement(ElementName:="textureheightbig", IsNullable:=False)> _
    Public Property TextureHeightBig() As String
        Get
            Return strTextureHeightBig
        End Get
        Set(ByVal Value As String)
            strTextureHeightBig = Value
        End Set
    End Property

    <XmlElement(ElementName:="spacebetweenitems", IsNullable:=False)> _
    Public Property SpaceBetweenItems() As String
        Get
            Return strSpaceBetweenItems
        End Get
        Set(ByVal Value As String)
            strSpaceBetweenItems = Value
        End Set
    End Property

    <XmlElement(ElementName:="spinposx", IsNullable:=False)> _
    Public Property SpinPosX() As String
        Get
            Return strSpinPosX
        End Get
        Set(ByVal Value As String)
            strSpinPosX = Value
        End Set
    End Property

    <XmlElement(ElementName:="spinposy", IsNullable:=False)> _
    Public Property SpinPosY() As String
        Get
            Return strSpinPosY
        End Get
        Set(ByVal Value As String)
            strSpinPosY = Value
        End Set
    End Property

    <XmlElement(ElementName:="spinwidth", IsNullable:=False)> _
    Public Property SpinWidth() As String
        Get
            Return strSpinWidth
        End Get
        Set(ByVal Value As String)
            strSpinWidth = Value
        End Set
    End Property

    <XmlElement(ElementName:="spinheight", IsNullable:=False)> _
    Public Property SpinHeight() As String
        Get
            Return strSpinHeight
        End Get
        Set(ByVal Value As String)
            strSpinHeight = Value
        End Set
    End Property

    <XmlElement(ElementName:="spincolor", IsNullable:=False)> _
    Public Property SpinColor() As String
        Get
            Return strSpinColor
        End Get
        Set(ByVal Value As String)
            strSpinColor = Value
        End Set
    End Property

    <XmlElement(ElementName:="pulseonselect", IsNullable:=False)> _
    Public Property PulseOnSelect() As String
        Get
            Return strPulseOnSelect
        End Get
        Set(ByVal Value As String)
            strPulseOnSelect = Value
        End Set
    End Property

    <XmlElement(ElementName:="onclick", IsNullable:=False)> _
    Public Property OnClick() As String()
        Get
            Return strOnClick
        End Get
        Set(ByVal Value As String())
            strOnClick = Value
        End Set
    End Property

    <XmlElement(ElementName:="onfocus", IsNullable:=False)> _
    Public Property OnFocus() As String
        Get
            Return strOnFocus
        End Get
        Set(ByVal Value As String)
            strOnFocus = Value
        End Set
    End Property

    <XmlElement(ElementName:="onup", IsNullable:=False)> _
    Public Property OnUp() As String
        Get
            Return strOnUp
        End Get
        Set(ByVal Value As String)
            strOnUp = Value
        End Set
    End Property

    <XmlElement(ElementName:="ondown", IsNullable:=False)> _
    Public Property OnDown() As String
        Get
            Return strOnDown
        End Get
        Set(ByVal Value As String)
            strOnDown = Value
        End Set
    End Property

    <XmlElement(ElementName:="onleft", IsNullable:=False)> _
    Public Property OnLeft() As String
        Get
            Return strOnLeft
        End Get
        Set(ByVal Value As String)
            strOnLeft = Value
        End Set
    End Property

    <XmlElement(ElementName:="onright", IsNullable:=False)> _
    Public Property OnRight() As String
        Get
            Return strOnRight
        End Get
        Set(ByVal Value As String)
            strOnRight = Value
        End Set
    End Property

    <XmlElement(ElementName:="numbuttons", IsNullable:=False)> _
    Public Property NumButtons() As String
        Get
            Return strNumButtons
        End Get
        Set(ByVal Value As String)
            strNumButtons = Value
        End Set
    End Property

    <XmlElement(ElementName:="buttongap", IsNullable:=False)> _
    Public Property ButtonGap() As String
        Get
            Return strButtonGap
        End Get
        Set(ByVal Value As String)
            strButtonGap = Value
        End Set
    End Property

    <XmlElement(ElementName:="orientation", IsNullable:=False)> _
    Public Property Orientation() As String
        Get
            Return strOrientation
        End Get
        Set(ByVal Value As String)
            strOrientation = Value
        End Set
    End Property

    <XmlElement(ElementName:="defaultbutton", IsNullable:=False)> _
    Public Property DefaultButton() As String
        Get
            Return strDefaultButton
        End Get
        Set(ByVal Value As String)
            strDefaultButton = Value
        End Set
    End Property

    <XmlElement(ElementName:="movement", IsNullable:=False)> _
    Public Property Movement() As String
        Get
            Return strMovement
        End Get
        Set(ByVal Value As String)
            strMovement = Value
        End Set
    End Property

    <XmlElement(ElementName:="alpha", IsNullable:=False)> _
    Public Property Alpha() As String
        Get
            Return strAlpha
        End Get
        Set(ByVal Value As String)
            strAlpha = Value
        End Set
    End Property

    <XmlElement(ElementName:="wraparound", IsNullable:=False)> _
    Public Property WrapAround() As String
        Get
            Return strWrapAround
        End Get
        Set(ByVal Value As String)
            strWrapAround = Value
        End Set
    End Property

    <XmlElement(ElementName:="smoothscrolling", IsNullable:=False)> _
    Public Property SmoothScrolling() As String
        Get
            Return strSmoothScrolling
        End Get
        Set(ByVal Value As String)
            strSmoothScrolling = Value
        End Set
    End Property

    <XmlElement(ElementName:="buttons", IsNullable:=False)> _
    Public Property Buttons() As Buttons
        Get
            Return objButtons
        End Get
        Set(ByVal Value As Buttons)
            objButtons = Value
        End Set
    End Property

    <XmlElement(ElementName:="scroll", IsNullable:=False)> _
    Public Property Scroll() As String
        Get
            Return strScroll
        End Get
        Set(ByVal Value As String)
            strScroll = Value
        End Set
    End Property

    <XmlElement(ElementName:="label", IsNullable:=False)> _
    Public Property Label() As String()
        Get
            Return strLabel
        End Get
        Set(ByVal Value As String())
            strLabel = Value
        End Set
    End Property

    <XmlElement(ElementName:="number", IsNullable:=False)> _
    Public Property Number() As String
        Get
            Return strNumber
        End Get
        Set(ByVal Value As String)
            strNumber = Value
        End Set
    End Property

    <XmlElement(ElementName:="colordiffuse", IsNullable:=False)> _
    Public Property ColorDiffuse() As String
        Get
            Return strColorDiffuse
        End Get
        Set(ByVal Value As String)
            strColorDiffuse = Value
        End Set
    End Property

    <XmlElement(ElementName:="colorkey", IsNullable:=False)> _
    Public Property ColorKey() As String
        Get
            Return strColorKey
        End Get
        Set(ByVal Value As String)
            strColorKey = Value
        End Set
    End Property

    <XmlElement(ElementName:="texture", IsNullable:=False)> _
    Public Property Texture() As String
        Get
            Return strTexture
        End Get
        Set(ByVal Value As String)
            strTexture = Value
        End Set
    End Property

    <XmlElement(ElementName:="haspath", IsNullable:=False)> _
    Public Property HasPath() As String
        Get
            Return strHasPath
        End Get
        Set(ByVal Value As String)
            strHasPath = Value
        End Set
    End Property

    <XmlElement(ElementName:="font", IsNullable:=False)> _
    Public Property Font() As String
        Get
            Return strFont
        End Get
        Set(ByVal Value As String)
            strFont = Value
        End Set
    End Property

    <XmlElement(ElementName:="font2", IsNullable:=False)> _
    Public Property Font2() As String
        Get
            Return strFont2
        End Get
        Set(ByVal Value As String)
            strFont2 = Value
        End Set
    End Property

    <XmlElement(ElementName:="textcolor", IsNullable:=False)> _
    Public Property TextColor() As String
        Get
            Return strTextColor
        End Get
        Set(ByVal Value As String)
            strTextColor = Value
        End Set
    End Property

    <XmlElement(ElementName:="textcolor2", IsNullable:=False)> _
    Public Property TextColor2() As String
        Get
            Return strTextColor2
        End Get
        Set(ByVal Value As String)
            strTextColor2 = Value
        End Set
    End Property

    <XmlElement(ElementName:="disabledcolor", IsNullable:=False)> _
    Public Property DisabledColor() As String
        Get
            Return strDisabledColor
        End Get
        Set(ByVal Value As String)
            strDisabledColor = Value
        End Set
    End Property

    <XmlElement(ElementName:="selectedcolor", IsNullable:=False)> _
    Public Property SelectedColor() As String
        Get
            Return strSelectedColor
        End Get
        Set(ByVal Value As String)
            strSelectedColor = Value
        End Set
    End Property

    <XmlElement(ElementName:="selectedcolor2", IsNullable:=False)> _
    Public Property SelectedColor2() As String
        Get
            Return strSelectedColor2
        End Get
        Set(ByVal Value As String)
            strSelectedColor2 = Value
        End Set
    End Property

    <XmlElement(ElementName:="shadow", IsNullable:=False)> _
    Public Property Shadow() As String
        Get
            Return strShadow
        End Get
        Set(ByVal Value As String)
            strShadow = Value
        End Set
    End Property

    <XmlElement(ElementName:="shadowcolor", IsNullable:=False)> _
    Public Property ShadowColor() As String
        Get
            Return strShadowColor
        End Get
        Set(ByVal Value As String)
            strShadowColor = Value
        End Set
    End Property

    <XmlElement(ElementName:="headlinecolor", IsNullable:=False)> _
    Public Property HeadlineColor() As String
        Get
            Return strHeadlineColor
        End Get
        Set(ByVal Value As String)
            strHeadlineColor = Value
        End Set
    End Property


    <XmlElement(ElementName:="titlecolor", IsNullable:=False)> _
    Public Property TitleColor() As String
        Get
            Return strTitleColor
        End Get
        Set(ByVal Value As String)
            strTitleColor = Value
        End Set
    End Property

    <XmlElement(ElementName:="urlset", IsNullable:=False)> _
    Public Property UrlSet() As String
        Get
            Return strUrlSet
        End Get
        Set(ByVal Value As String)
            strUrlSet = Value
        End Set
    End Property

    <XmlElement(ElementName:="subtype", IsNullable:=False)> _
    Public Property SubType() As String
        Get
            Return strSubType
        End Get
        Set(ByVal Value As String)
            strSubType = Value
        End Set
    End Property

    <XmlElement(ElementName:="reverse", IsNullable:=False)> _
    Public Property Reverse() As String
        Get
            Return strReverse
        End Get
        Set(ByVal Value As String)
            strReverse = Value
        End Set
    End Property

    <XmlElement(ElementName:="range", IsNullable:=False)> _
    Public Property Range() As String
        Get
            Return strRange
        End Get
        Set(ByVal Value As String)
            strRange = Value
        End Set
    End Property

    <XmlElement(ElementName:="angle", IsNullable:=False)> _
    Public Property Angle() As String
        Get
            Return strAngle
        End Get
        Set(ByVal Value As String)
            strAngle = Value
        End Set
    End Property

    <XmlElement(ElementName:="aspectratio", IsNullable:=False)> _
    Public Property AspectRatio() As String
        Get
            Return strAspectRatio
        End Get
        Set(ByVal Value As String)
            strAspectRatio = Value
        End Set
    End Property

    <XmlElement(ElementName:="wrapmultiline", IsNullable:=False)> _
    Public Property WrapMultiLine() As String
        Get
            Return strWrapMultiLine
        End Get
        Set(ByVal Value As String)
            strWrapMultiLine = Value
        End Set
    End Property

    <XmlElement(ElementName:="gfxthumbwidth", IsNullable:=False)> _
Public Property GfxThumbWidth() As String
        Get
            Return strGfxThumbWidth
        End Get
        Set(ByVal Value As String)
            strGfxThumbWidth = Value
        End Set
    End Property

    <XmlElement(ElementName:="gfxthumbheight", IsNullable:=False)> _
    Public Property GfxThumbHeight() As String
        Get
            Return strGfxThumbHeight
        End Get
        Set(ByVal Value As String)
            strGfxThumbHeight = Value
        End Set
    End Property

    <XmlElement(ElementName:="gfxthumbspacex", IsNullable:=False)> _
    Public Property GfxThumbSpaceX() As String
        Get
            Return strGfxThumbSpaceX
        End Get
        Set(ByVal Value As String)
            strGfxThumbSpaceX = Value
        End Set
    End Property

    <XmlElement(ElementName:="gfxthumbspacey", IsNullable:=False)> _
    Public Property GfxThumbSpaceY() As String
        Get
            Return strGfxThumbSpaceY
        End Get
        Set(ByVal Value As String)
            strGfxThumbSpaceY = Value
        End Set
    End Property

    <XmlElement(ElementName:="gfxthumbdefault", IsNullable:=False)> _
    Public Property GfxThumbDefault() As String
        Get
            Return strGfxThumbDefault
        End Get
        Set(ByVal Value As String)
            strGfxThumbDefault = Value
        End Set
    End Property

    <XmlElement(ElementName:="bitmaps", IsNullable:=False)> _
    Public Property Bitmaps() As String
        Get
            Return strBitmaps
        End Get
        Set(ByVal Value As String)
            strBitmaps = Value
        End Set
    End Property

    <XmlElement(ElementName:="spinfont", IsNullable:=False)> _
    Public Property SpinFont() As String
        Get
            Return strSpinFont
        End Get
        Set(ByVal Value As String)
            strSpinFont = Value
        End Set
    End Property

    <XmlElement(ElementName:="markwidth", IsNullable:=False)> _
    Public Property MarkWidth() As String
        Get
            Return strMarkWidth
        End Get
        Set(ByVal Value As String)
            strMarkWidth = Value
        End Set
    End Property

    <XmlElement(ElementName:="markheight", IsNullable:=False)> _
    Public Property MarkHeight() As String
        Get
            Return strMarkHeight
        End Get
        Set(ByVal Value As String)
            strMarkHeight = Value
        End Set
    End Property

    <XmlElement(ElementName:="sliderwidth", IsNullable:=False)> _
    Public Property SliderWidth() As String
        Get
            Return strSliderWidth
        End Get
        Set(ByVal Value As String)
            strSliderWidth = Value
        End Set
    End Property

    <XmlElement(ElementName:="sliderheight", IsNullable:=False)> _
    Public Property SliderHeight() As String
        Get
            Return strSliderHeight
        End Get
        Set(ByVal Value As String)
            strSliderHeight = Value
        End Set
    End Property

    <XmlElement(ElementName:="texturecheckmark", IsNullable:=False)> _
    Public Property TextureCheckMark() As String
        Get
            Return strTextureCheckMark
        End Get
        Set(ByVal Value As String)
            strTextureCheckMark = Value
        End Set
    End Property

    <XmlElement(ElementName:="texturecheckmarknofocus", IsNullable:=False)> _
    Public Property TextureCheckMarkNoFocus() As String
        Get
            Return strTextureCheckMarkNoFocus
        End Get
        Set(ByVal Value As String)
            strTextureCheckMarkNoFocus = Value
        End Set
    End Property

    <XmlElement(ElementName:="texturesliderbar", IsNullable:=False)> _
    Public Property TextureSliderBar() As String
        Get
            Return strTextureSliderBar
        End Get
        Set(ByVal Value As String)
            strTextureSliderBar = Value
        End Set
    End Property

    <XmlElement(ElementName:="disposition", IsNullable:=False)> _
    Public Property Disposition() As String
        Get
            Return strDisposition
        End Get
        Set(ByVal Value As String)
            strDisposition = Value
        End Set
    End Property

    <XmlElement(ElementName:="title", IsNullable:=False)> _
    Public Property Title() As String
        Get
            Return strTitle
        End Get
        Set(ByVal Value As String)
            strTitle = Value
        End Set
    End Property

    <XmlElement(ElementName:="tagset", IsNullable:=False)> _
    Public Property TagSet() As String
        Get
            Return strTagSet
        End Get
        Set(ByVal Value As String)
            strTagSet = Value
        End Set
    End Property

    <XmlElement(ElementName:="lefttexture", IsNullable:=False)> _
    Public Property LeftTexture() As String
        Get
            Return strLeftTexture
        End Get
        Set(ByVal Value As String)
            strLeftTexture = Value
        End Set
    End Property

    <XmlElement(ElementName:="midtexture", IsNullable:=False)> _
    Public Property MidTexture() As String
        Get
            Return strMidTexture
        End Get
        Set(ByVal Value As String)
            strMidTexture = Value
        End Set
    End Property

    <XmlElement(ElementName:="righttexture", IsNullable:=False)> _
    Public Property RightTexture() As String
        Get
            Return strRightTexture
        End Get
        Set(ByVal Value As String)
            strRightTexture = Value
        End Set
    End Property

    <XmlElement(ElementName:="overlaytexture", IsNullable:=False)> _
    Public Property OverlayTexture() As String
        Get
            Return strOverlayTexture
        End Get
        Set(ByVal Value As String)
            strOverlayTexture = Value
        End Set
    End Property

    <XmlElement(ElementName:="keepaspectratio", IsNullable:=False)> _
    Public Property KeepAspectRatio() As String
        Get
            Return strKeepAspectRatio
        End Get
        Set(ByVal Value As String)
            strKeepAspectRatio = Value
        End Set
    End Property

    <XmlElement(ElementName:="randomize", IsNullable:=False)> _
    Public Property Randomize() As String
        Get
            Return strRandomize
        End Get
        Set(ByVal Value As String)
            strRandomize = Value
        End Set
    End Property

    <XmlElement(ElementName:="radiowidth", IsNullable:=False)> _
    Public Property RadioWidth() As String
        Get
            Return strRadioWidth
        End Get
        Set(ByVal Value As String)
            strRadioWidth = Value
        End Set
    End Property

    <XmlElement(ElementName:="radioheight", IsNullable:=False)> _
    Public Property RadioHeight() As String
        Get
            Return strRadioHeight
        End Get
        Set(ByVal Value As String)
            strRadioHeight = Value
        End Set
    End Property

    <XmlElement(ElementName:="radioposx", IsNullable:=False)> _
    Public Property RadioPosX() As String
        Get
            Return strRadioPosX
        End Get
        Set(ByVal Value As String)
            strRadioPosX = Value
        End Set
    End Property

    <XmlElement(ElementName:="radioposy", IsNullable:=False)> _
    Public Property RadioPosY() As String
        Get
            Return strRadioPosY
        End Get
        Set(ByVal Value As String)
            strRadioPosY = Value
        End Set
    End Property

    <XmlElement(ElementName:="include", IsNullable:=False)> _
    Public Property Include() As String()
        Get
            Return strInclude
        End Get
        Set(ByVal Value As String())
            strInclude = Value
        End Set
    End Property

End Class
