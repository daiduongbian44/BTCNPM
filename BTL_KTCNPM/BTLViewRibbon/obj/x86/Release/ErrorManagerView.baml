   M S B A M L   `   `   `  ���� `  \RibbonControlsLibrary, Version=4.0.0.11019, Culture=neutral, PublicKeyToken=31bf3856ad364e35tNclr-namespace:Microsoft.Windows.Controls.Ribbon;assembly=RibbonControlsLibrary!Microsoft.Windows.Controls.Ribbon  H DBTLViewRibbon, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:BTLViewRibbon.ViewsBTLViewRibbon.Views *   $BTLViewRibbon.Views.ErrorManagerView   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     aribbonNclr-namespace:Microsoft.Windows.Controls.Ribbon;assembly=RibbonControlsLibrary     3local!clr-namespace:BTLViewRibbon.Views     -   4   .Microsoft.Windows.Controls.Ribbon.RibbonWindow   Name$  Window�� � Title$ ErrorManagerView��$	��640��$	��480��.��� -    �Name$ 
LayoutRoot�� � RowDefinitions �� $
��Auto ��� $��* �.+�.   (Microsoft.Windows.Controls.Ribbon.Ribbon  -     Name$ Ribbon��   ApplicationMenu =   7Microsoft.Windows.Controls.Ribbon.RibbonApplicationMenu  8   2Microsoft.Windows.Controls.Ribbon.RibbonMenuButton   SmallImageSource$ ..\Images\SmallIcon.png��.@�A   ;Microsoft.Windows.Controls.Ribbon.RibbonApplicationMenuItem  -     Name$ 	MenuItem1��$��Hello _Ribbon��6   0Microsoft.Windows.Controls.Ribbon.RibbonMenuItem   ImageSource$ ..\Images\LargeIcon.png��.@�1   +Microsoft.Windows.Controls.Ribbon.RibbonTab  $
��Home��.@�3   -Microsoft.Windows.Controls.Ribbon.RibbonGroup  $��Manager��	   GroupSizeDefinitions	 A	   ;Microsoft.Windows.Controls.Ribbon.RibbonGroupSizeDefinition	  
 	  ControlSizeDefinitions.
 C
   =Microsoft.Windows.Controls.Ribbon.RibbonControlSizeDefinition
   
  	ImageSize$ Large=� 
  IsLabelVisible . 
  $ Large=� . 
  $ Large=� . 
  $ Large=� . 	  E   ?Microsoft.Windows.Controls.Ribbon.RibbonGroupSizeDefinitionBase   IsCollapsed . .@�4   .Microsoft.Windows.Controls.Ribbon.RibbonButton     Label$	 Add��   LargeImageSource$ ..\Images\LargeIcon.png��*  $BTLViewRibbon.Views.ErrorManagerView   
AddCommand#��Z   $ Update��$ ..\Images\LargeIcon.png��   UpdateCommand#��Z   $ Delete��$ ..\Images\LargeIcon.png��   DeleteCommand#��Z � $��1�� � ColumnDefinitions �� $	��200 ��� $��* �.+��� -    ��Name$ grbBoxError��$��0��$��5,0,0,5q�$��Error��.��� .+��� -   $��
textBlock1��$��18��$��6,6,18,0q�$	��Top=�$
��Name���� -   $��txtName��$��19��$��6,23,6,0q�$	��Top=��� -   $��
textBlock2��$��18��$��	6,46,18,0q�$	��Top=�$��Vf���� -	   $��txtVf��$��19��$��6,63,6,0q�$	��Top=��� -
   $��
textBlock3��$��21��$��	6,86,18,0q�$	��Top=�$��Cf���� -   $��txtCf��$��22��$��	6,103,6,0q�$	��Top=��� -   $��
textBlock4��$��18��$��
6,130,18,0q�$	��Top=�$��Pi���� -   $��txtPi��$��19��$��	6,147,6,0q�$	��Top=��� -   $��button1��$��75��$��23��$��	6,172,0,0q�$
��Left=�$	��Top=�$	��Add���� -   $��button3��$��75��$��23��$��
87,172,0,0q�$
��Left=�$	��Top=�$��Clear���� -   $��button2��$��75��$��23��$��0,0,6,6q�$��Right=�$��Bottom=�$��Cancel���� $��2��
������ �� -   $ grbListError��$��1��$��5,0,0,5q�$��List Errors��.��&   System.Windows.Controls.DataGrid  -   $��dataGridError��   AutoGenerateColumns .     
IsReadOnly . ����    Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ 50    Header$	 STT��1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *STT+  $ * $
 Name�� �� *Name+  $ 50 $ Vf�� �� *
VfFactor+  $ 50 $ Cf�� �� *
CfFactor+  $ 50 $ Pi�� �� *
PiFactor+