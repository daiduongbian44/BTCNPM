   M S B A M L   `   `   `  ����H  DBTLViewRibbon, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:BTLViewRibbon.UserControlsBTLViewRibbon.UserControls  5      ` \RibbonControlsLibrary, Version=4.0.0.11019, Culture=neutral, PublicKeyToken=31bf3856ad364e35tNclr-namespace:Microsoft.Windows.Controls.Ribbon;assembly=RibbonControlsLibrary!Microsoft.Windows.Controls.Ribbon 5          BTLViewRibbon.MainWindow   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      7my(clr-namespace:BTLViewRibbon.UserControls     5      aribbonNclr-namespace:Microsoft.Windows.Controls.Ribbon;assembly=RibbonControlsLibrary     5      -   5        4  .Microsoft.Windows.Controls.Ribbon.RibbonWindow   Name$  RibbonWindow��5      $
��1000��5	      $	��600��5
       � Icon$ Images/icon.png��5       � WindowStartupLocation$ CenterScreen=�5       � WindowState$ 	Maximized=�5       � Title 5      ��  �� Path$ TitleMainWindow�   	Resources �� Source# [  .��5      � -   5         �Name$ 
LayoutRoot��5       � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   .  (Microsoft.Windows.Controls.Ribbon.Ribbon  -   5        	  Name$	 Ribbon��5      
   ApplicationMenu
 5      =  7Microsoft.Windows.Controls.Ribbon.RibbonApplicationMenu  5      8  2Microsoft.Windows.Controls.Ribbon.RibbonMenuButton   SmallImageSource$ Images\SmallIcon.png��6/   .@�5      A  ;Microsoft.Windows.Controls.Ribbon.RibbonApplicationMenuItem  -   5          Name$ 	MenuItem1��5   7   $��Hello _Ribbon��5   7   6  0Microsoft.Windows.Controls.Ribbon.RibbonMenuItem   ImageSource$ Images\LargeIcon.png��5   7   5      .@�5      1  +Microsoft.Windows.Controls.Ribbon.RibbonTab  $
��Home��6   .@�5      3  -Microsoft.Windows.Controls.Ribbon.RibbonGroup  $��Manager��6%      GroupSizeDefinitions 5!      A	  ;Microsoft.Windows.Controls.Ribbon.RibbonGroupSizeDefinition	   	  ControlSizeDefinitions. 5"      C
  =Microsoft.Windows.Controls.Ribbon.RibbonControlSizeDefinition
   
  	ImageSize$ Large=�6A    
  IsLabelVisible . 6S   
  5#      $ Large=�6A    . 6S   
  5$      $ Large=�6A    . 6S   
  5%      $ Large=�6A    . 6S   5&      	  5'      E  ?Microsoft.Windows.Controls.Ribbon.RibbonGroupSizeDefinitionBase   IsCollapsed . 6;   .@�5)      4  .Microsoft.Windows.Controls.Ribbon.RibbonButton     Label$ Button1��6*      LargeImageSource$ Images\LargeIcon.png��6:     5*      $ Button2��6*   $ Images\LargeIcon.png��6:     5+      $ Button3��6*   $ Images\LargeIcon.png��6:     5,      $ Button4��6*   $ Images\LargeIcon.png��6:   5-        5/      $��Language��6%    51      	  . 52      
  $ Large=�6A    . 6S   53      	  54       . 6;   .@�57      �� -   5         ��Name$ cbLanguages��57      $	��150��58      $��28��59      $
��Left=�5:      $��Center=�5;      $��0, 20, 0, 0q�5<      ��5=      �� $ SupportedCultures� �� Mode$ OneWay=�  CultureResourcesDS# [ ��5@      �� 5A      .R�5B   "   �� .+�5C   &   �� ��60   �� *
NativeName+5D   #   5E      5G      5H      5I      5J      � 5L   
   $��2��6    � ColumnDefinitions 5M      �� 5N      $	��270 �6#   �� 5O      $��* �6#   �� 5P      $	��200 �6#   .+�5S      � $��0��6   .+�5T      �� $��5, 10q�6   $��
Parameters��6*   .��5U      ��  �� Orientation$ Vertical=�6!   .+�5V      �� $��20��6$   $��
10,10,10,0q�5W   $   $��KLOC:��5X   $   $
��Wrap=�5Y   $   �� 5Z      $��26��6"   $��	10,0,10,0q�5[   "   $�� ��5\   "    �� TextWrapping$
 Wrap=�5]   "   $��Center=�5^   "   �� 5`      $��20��6$   $��
10,10,10,0q�5a   $   $��Error/KLOC:��5b   $   $
��Wrap=�5c   $   �� 5d      $��26��6"   $��	10,0,10,0q�5e   "   $�� ��5f   "   $
 Wrap=�5g   "   $��Center=�5h   "   �� 5j      $��20��6$   $��
10,10,10,0q�5k   $   $��Number of errors:��5l   $   $
��Wrap=�5m   $   �� 5n      $��26��6"   $��	10,0,10,0q�5o   "   $�� ��5p   "   $
 Wrap=�5q   "   $��Center=�5r   "   �� 5t      $��20��6$   $��
10,10,10,0q�5u   $   $��Labor cost:��5v   $   $
��Wrap=�5w   $   �� 5x      $��26��6"   $��	10,0,10,0q�5y   "   $�� ��5z   "   $
 Wrap=�5{   "   $��Center=�5|   "   �� 5~      $��20��6$   $��
10,10,10,0q�5   $   $#��Distribution of defect types:��5�   $   $
��Wrap=�5�   $   �� 5�      $��20��6$   $��
10,10,10,0q�5�   $   $��Documents: (%)��5�   $   $
��Wrap=�5�   $   4   .BTLViewRibbon.UserControls.SliderTextBoxCustom  5�      $��	10,0,10,0q�61   �� 5�      $��20��6$   $��
10,10,10,0q�5�   $   $��
Logic: (%)��5�   $   $
��Wrap=�5�   $     5�      $��	10,0,10,0q�61   �� 5�      $��20��6$   $��
10,10,10,0q�5�   $   $��	Data: (%)��5�   $   $
��Wrap=�5�   $     5�      $��	10,0,10,0q�61   �� 5�      $��20��6$   $��
10,10,10,0q�5�   $   $��Syntax: (%)��5�   $   $
��Wrap=�5�   $     5�      $��	10,0,10,0q�61   �� 5�      $��20��6$   $��
10,10,10,0q�5�   $   $��Comp/Mem: (%)��5�   $   $
��Wrap=�5�   $     5�      $��	10,0,10,0q�61   5�      5�      5�      � 5�      $��1��6   .+�5�      �� $��5, 10q�6   $ ��Error Types And Techniques��6*   .��5�      &   System.Windows.Controls.DataGrid  $��5q�6      AutoGenerateColumns .     
IsReadOnly .    Columns 5�      0  *System.Windows.Controls.DataGridTextColumn  5�      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ 80 61      Header$ Error��6<     5�      $	 100 61   $ 	Unit Test��6=     5�      $	 120 61   $ Functional Test��6=     5�      $	 100 61   $ Integrate Test��6=     5�      $  * 61   $ Overall Test��6<   5�      5�      5�      � 5�      $��2��6   $
��5,10q�6#    5�      �� 5�      $
��Auto �6$   $	��200��62   �� 5�      $��* �6$   .+�5�      � $��0��6   .+�5�      �� $
��Plan��6   .��5�        $��5q�6#    .   5�        5�   "   $ * 65   $ 	Technique��6?   5�      5�      5�      � 5�      $��1��6   .+�5�      �� $��Result��6   .��5�      � .+�5�      �� .+�5�   "   �� $��20��6,   $��
10,10,10,0q�5�   ,   $��Direct cost:��5�   ,   $
��Wrap=�5�   ,   �� 5�   "   $��26��6*   $��	10,0,10,0q�5�   *   $�� ��5�   *   $
 Wrap=�5�   *   $��Center=�5�   *   �� 5�   "   $��20��6,   $��
10,10,10,0q�5�   ,   $��Future cost:��5�   ,   $
��Wrap=�5�   ,   �� 5�   "   $��26��6*   $��	10,0,10,0q�5�   *   $�� ��5�   *   $
 Wrap=�5�   *   $��Center=�5�   *   �� 5�   "   $��20��6,   $��
10,10,10,0q�5�   ,   $��Revenue:��5�   ,   $
��Wrap=�5�   ,   �� 5�   "   $��26��6*   $��	10,0,10,0q�5�   *   $�� ��5�   *   $
 Wrap=�5�   *   $��Center=�5�   *   �� 5�   "   $��20��6,   $��
10,10,10,0q�5�   ,   $��Total cost:��5�   ,   $
��Wrap=�5�   ,   �� 5�   "   $��26��6*   $��	10,0,10,0q�5�   *   $�� ��5�   *   $
 Wrap=�5�   *   $��Center=�5�   *   �� 5�   "   $��20��6,   $��
10,10,10,0q�5�   ,   $��Profit:��5�   ,   $
��Wrap=�5�   ,   �� 5�   "   $��26��6*   $��	10,0,10,0q�5�   *   $�� ��5�   *   $
 Wrap=�5�   *   $��Center=�5�   *   �� 5�   "   $��20��6,   $��
10,10,10,0q�5�   ,   $
��ROI:��5�   ,   $
��Wrap=�5�   ,   �� 5�   "   $��26��6*   $��	10,0,10,0q�5�   *   $�� ��5�   *   $
 Wrap=�5�   *   $��Center=�5   *   5     5     5     5     5     5     5     5     