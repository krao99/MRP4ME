   M S B A M L   `   `   `  ���� N  JCustomChromeLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullV>clr-namespace:CustomChromeLibrary;assembly=CustomChromeLibraryCustomChromeLibrary  I ECustomControls, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG4clr-namespace:CustomControls;assembly=CustomControlsCustomControls O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem A =MRP4ME, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:MRP4MEMRP4ME    MRP4ME.MainWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     R NMicrosoft.Windows.Shell, Version=3.0.1.0, Culture=neutral, PublicKeyToken=nullKshell?http://schemas.microsoft.com/winfx/2006/xaml/presentation/shell  Hccl>clr-namespace:CustomChromeLibrary;assembly=CustomChromeLibrary  Acustom4clr-namespace:CustomControls;assembly=CustomControls  0sys&clr-namespace:System;assembly=mscorlib   localclr-namespace:MRP4ME  -   ,   &CustomChromeLibrary.CustomChromeWindow   Name$  winHome�� � Title$ MRP4ME��$	��700��$	��970�� � 
ResizeMode$ NoResize=� � WindowStartupLocation$ CenterScreen=� � Icon$ images/mrp4meIcon.PNG��*  $Microsoft.Windows.Shell.WindowChrome   WindowChrome      ResizeBorderThickness$ 6q�   CaptionHeight$ 43Q�   CornerRadius$ 25,25,10,10��	   GlassFrameThickness$	 0q�
 � 	Resources
 /  )MRP4ME.CaptionButtonRectToMarginConverter    CaptionButtonMarginConverter �� MergedDictionaries �� Source��  �� $  Resources\GlassButton.xaml?��� $ Resources\GlassIcon.xaml?�%   &	          .���  � ColumnDefinitions �� $��* � � RowDefinitions �� $
��auto ��� $��* �.+���  �� CornerRadius$ 	10,10,5,5��$��2��$��1q�
����İ�����  �� 
StartPoint$ 0.5,0&� �� EndPoint$ 0.5,1&�.���  � Color$ 	#999FBF91�� � Offset$ 0Q�� $ 	#FFCFD1CD��$ 1Q��� $ 	10,10,0,0��$��3,3,3,1q�
����İ�����  �� Path$ CaptionButtonMargin����� $ 0.5,0&�$ 0.5,1&�.��� $ 	#FF869C7D��$ 0Q�� $ 	#FF97B477��$ 1Q�._���  �� Orientation$ 
Horizontal=�$��0q�$	��Top=�.+�$   CustomChromeLibrary.WindowIcon  $��35��$��35�����	#FF49614A$��7,3,5,5q�  	GlassIcon#��[ �� $��MRP4ME��$��Ravie)�$
��Bold"�$��26(����	#FF000044$��Center=�(   "CustomChromeLibrary.CaptionButtons  � $��1��.+��� -    ��Name$ tabCtrlMain��$��5,4,0,10q�$��16(�
������ 
������ $��0q�
  �� 
TargetType �� Property �� Value ��Name �� Triggers �� Value �� Binding �� RelativeSource �� Mode  �� AncestorType! �� 
TargetName��%  '��       �� " ��.���  � ��$ 0q���  � ��$ 0q���  � �� �� .R��� $
 grid�����	#FF97B477._��� ���� $��0q�$��15(�#��z�� �� $
 True�� ��  �� $ FindAncestor=�"  ��$ 
IsSelected�.a��� $
! grid�� � �� �	#FF97B477.@��� -   " ��Name$" tabItemWelcome��$��Welcome��$
��Left=�$	��109��$��0q����	#FF97B477.��� -   # �Name$# gridWelcome��
������ $��	0,-1,2,-5q�$ J� RenderTransformOrigin$$ 0.5,0.5&�$	��917��$	��529�� �� $
��418* ��� $	��64* ��� $
��435* �.+��� -   % ��Name$% 
lblWelcome��$��Welcome��$��Center=�$��Center=�$��48��$��	0,-29,3,0q�$	��Top=�$	��914��$��18(�$
��Bold"�$��3���� $��Bill of Materials��$
��Left=�$��
133,40,0,0q�$	��Top=�$��18(����	#FFF5600B�� $	��140��$��126,73,126,0q�$	��Top=�$��images/BOM.png��$
��Fill=�$	��165���� $	��140��$��166,340,105,0q�$	��Top=�$'��!images/Inventory Avaliability.png��$
��Fill=�$	��165��$��2���� $	��140��$��378,73,374,0q�$	��Top=�$��images/Purchase Order.jpg��$
��Fill=�& �� StretchDirection$& DownOnly=�$	��165��$��3���� $	��140��$��150,73,120,0q�$	��Top=�$��images/Reports.jpg��$
��Fill=�$	��165��$��2���� $	��140��$��126,340,127,0q�$	��Top=�$'��!images/Material Specification.png��$
��Fill=�$	��165���� $	��140��$��380,340,373,0q�$	��Top=�$$��images/Production Schedule.jpg��$	��165��$
��Fill=�$��3���� $��Purchase Orders��$
��Left=�$��
385,40,0,0q�$	��Top=�$��18(�$��3�����	#FFF5600B�� $��Reports��$
��Left=�$��
192,40,0,0q�$	��Top=�$��18(�$��2�����	#FFF5600B�� $��Materials Specification��$
��Left=�$��116,308,0,0q�$	��Top=�$��18(����	#FFF5600B�� $��Production Schedule��$
��Left=�$��376,308,0,0q�$	��Top=�$��18(�$��3�����	#FFF5600B�� $��Inventory Avaliability��$
��Left=�$��160,308,0,0q�$	��Top=�$��18(�
������ $��2�����	#FFF5600B�� -   $" tabItemCreatePO��$��Purchase Order��$
��Left=�$	��169��$��0q����	#FF97B477' J� Opacity$	' 100Q�.��� -   $# gridCreatePO��( � ShowGridLines( . 
������ $
��Left=�$	��956��$	��602��$	��Top=�$��	0,0,-5,-3q�.+��� $��
10,10,10,0q�$��Verdana)�$��18(�$!��Create a new Purchase Order��$
��Bold"��� -   $% lblPONo��$��PO��$
��Left=�$��	61,84,0,0q�$	��Top=��� -	   ) ��Name$) txtPO��$
��Left=�$��28��$��
200,85,0,0q�* �� TextWrapping$
* Wrap=�$	��Top=�$	��140�����	#FFDBE0D6+ �� 	MaxLength$+ 6������ *PO+, �� Mode$, TwoWay=�"- �� ValidatesOnNotifyDataErrors- . �� -
   $% 	lblPOName��$
��Name��$
��Left=�$��
61,125,0,0q�$	��Top=��� -   $) txtName��$
��Left=�$��28��$��200,125,0,0q�$
* Wrap=�$	��Top=�$	��250�����	#FFDBE0D6$+ 20������ *Name+$, TwoWay=�- . �� -   $% 	lblPODesc��$��Description��$
��Left=�$��
61,165,0,0q�$	��Top=��� -   $) txtDescription��$
��Left=�$��90��$��199,170,0,0q�$
* Wrap=�. �� AcceptsReturn. . "/ �� VerticalScrollBarVisibility$/ Visible=�$	��Top=�$	��395�����	#FFDBE0D6$+ 60��.������ $ Description�0 �� UpdateSourceTrigger$0 PropertyChanged=�1 �� ValidationRules1 5  /System.Windows.Controls.ExceptionValidationRule  .���� -   $% lblAttachment��$��
Attachment��$
��Left=�$��
61,280,0,0q�$	��Top=��� -   $) txtAttachment��$
��Left=�$��28��$��198,281,0,0q�$
* Wrap=�$	��Top=�$	��512�����	#FFDBE0D6$	+ 255��.������ $ 
Attachment�$0 PropertyChanged=�1   .���� -   2 ��Name$2 btnAttachBrowse��$��Browse��$
��Left=�$��30��$��716,279,0,0q�$	��Top=�$��90�����	#FFE2A023�� -   $% lblUploadImage��$��Upload Image��$
��Left=�$��
61,326,0,0q�$	��Top=��� -   $) txtImage��$
��Left=�$��28��$��198,327,0,0q�$
* Wrap=�$	��Top=�$	��512�����	#FFDBE0D6$	+ 255��.������ $ Image�$0 PropertyChanged=�1   .���� -   $2 btnUploadImageBrowse��$��Browse��$
��Left=�$��30��$��716,326,0,0q�$	��Top=�$��90�����	#FFE2A023�� -   $% lblPOCreatedBy��$
��User��$
��Left=�$��
61,370,0,0q�$	��Top=��� -   $) txtUser��$
��Left=�$��28��$��198,371,0,0q�$
* Wrap=�$	��Top=�$	��250�����	#FFDBE0D6$+ 20��.������ $
 User�$0 PropertyChanged=�1   .���� -   $% lblLevel��$��Level��$
��Left=�$��
61,414,0,0q�$	��Top=��� -   $) txtLevel��$
��Left=�$��28��$��198,414,0,0q�$
* Wrap=�$	��Top=�$��62��3 �� 
IsReadOnly3 . ���	#FFDBE0D6.������ $ Level�$0 PropertyChanged=�1   .���� -   $2 	btnSavePO��$
��Save��$
��Left=�$��30��$��716,466,0,0q�$	��Top=�$	��100�����	#FFE2A023�� -   $" tabItemProdSched��$/��)Production Schedule                      ��$��32��$	��Top=�$��0,0,-8,0q�$
��Left=�$	��174�����	#FF97B477$y�Hidden=�.��� -   $# gridProdSched�����	#FFFFFFFF$��6,0,17,0q�$	��529��.+��� $��Production Schedule��$��Center=�$
��Left=�$��36��$��10,9,0,0q�$	��Top=�$	��866��$��20(�$
��Bold"��� $
��Left=�$��6��$��
745,38,0,0q�$	��Top=�$��0��$��1���� $��Label��$
��Left=�$��293,-123,0,0q�$	��Top=�