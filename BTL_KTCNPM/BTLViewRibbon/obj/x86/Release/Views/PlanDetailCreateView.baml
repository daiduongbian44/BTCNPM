   M S B A M L   `   `   `  ���� `  \RibbonControlsLibrary, Version=4.0.0.11019, Culture=neutral, PublicKeyToken=31bf3856ad364e35tNclr-namespace:Microsoft.Windows.Controls.Ribbon;assembly=RibbonControlsLibrary!Microsoft.Windows.Controls.Ribbon   BTLViewRibbon.   (BTLViewRibbon.Views.PlanDetailCreateView   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     aribbonNclr-namespace:Microsoft.Windows.Controls.Ribbon;assembly=RibbonControlsLibrary       � Title$  Plan Creation��$	��508��$	��600��.���  � RowDefinitions �� $
��Auto ��� $��* �.+�.   (Microsoft.Windows.Controls.Ribbon.Ribbon  -     Name$ Ribbon��$��0��   ApplicationMenu =   7Microsoft.Windows.Controls.Ribbon.RibbonApplicationMenu  8   2Microsoft.Windows.Controls.Ribbon.RibbonMenuButton   SmallImageSource$ ..\Images\SmallIcon.png��.@�A   ;Microsoft.Windows.Controls.Ribbon.RibbonApplicationMenuItem  -     Name$ 	MenuItem1��$��Hello _Ribbon��6   0Microsoft.Windows.Controls.Ribbon.RibbonMenuItem   ImageSource$ ..\Images\LargeIcon.png��.@�1   +Microsoft.Windows.Controls.Ribbon.RibbonTab  $
��Home��.@�3   -Microsoft.Windows.Controls.Ribbon.RibbonGroup  $��Manager��   GroupSizeDefinitions A   ;Microsoft.Windows.Controls.Ribbon.RibbonGroupSizeDefinition     ControlSizeDefinitions. C	   =Microsoft.Windows.Controls.Ribbon.RibbonControlSizeDefinition	  	 	  	ImageSize$	 Large=�
 	  IsLabelVisible
 . 	  $	 Large=�
 . 	  $	 Large=�
 . 	  $	 Large=�
 .   E
   ?Microsoft.Windows.Controls.Ribbon.RibbonGroupSizeDefinitionBase 
  IsCollapsed . .@�4   .Microsoft.Windows.Controls.Ribbon.RibbonButton     Label$ Button1��   LargeImageSource$ ..\Images\LargeIcon.png��  $ Button2��$ ..\Images\LargeIcon.png��  $ Button3��$ ..\Images\LargeIcon.png��  $ Button4��$ ..\Images\LargeIcon.png��� $��1��$��0, 20, 0, 0q� � ColumnDefinitions �� $
��152* ��� $
��Auto ��� $
��239* �.+�� $��0��.+��� $��0q�$��List Techniques��.��� .+��� $��0,0,0,0q����� ���� .R���  �� Orientation$ 
Horizontal=�.+��� ���� *STT+�� $��.���� ���� *Name+� $��1��$��0,0,0,0q�.+��� $��75��$��23��$��10q�$	��Top=�$	��Add���� $��2��$
��Plan��.��� $��2��$��0,0,0,0q� �� $��* ��� $
��Auto �.+��� $��0������ ���� .R��� $ 
Horizontal=�.+��� ���� *STT+�� $��.���� ���� *Name+�� 