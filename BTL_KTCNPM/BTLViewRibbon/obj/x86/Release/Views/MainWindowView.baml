   M S B A M L   `   `   `  ���� c  _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35qPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.InteractivitySystem.Windows.Interactivity  H DBTLViewRibbon, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:BTLViewRibbon.UserControlsBTLViewRibbon.UserControls ` \RibbonControlsLibrary, Version=4.0.0.11019, Culture=neutral, PublicKeyToken=31bf3856ad364e35tNclr-namespace:Microsoft.Windows.Controls.Ribbon;assembly=RibbonControlsLibrary!Microsoft.Windows.Controls.Ribbon C&clr-namespace:BTLViewRibbon.ViewModelsBTLViewRibbon.ViewModels (   "BTLViewRibbon.Views.MainWindowView   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     ^iPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.Interactivity     7my(clr-namespace:BTLViewRibbon.UserControls     aribbonNclr-namespace:Microsoft.Windows.Controls.Ribbon;assembly=RibbonControlsLibrary     5vm&clr-namespace:BTLViewRibbon.ViewModels     -   4  .Microsoft.Windows.Controls.Ribbon.RibbonWindow   Name$  RibbonWindow��$
��1366��$	��768��$��13(� � Icon$ ../Images/icon.png�� � WindowStartupLocation$ CenterScreen=� � WindowState$ 	Maximized=� � Title ��  �� Path$ TitleMainWindow�   	Resources �� Source# [   � 	Resources 2  ,BTLViewRibbon.ViewModels.MainWindowViewModel  	viewModel��%   &	         .��� -    �Name$ 
LayoutRoot��	 � DataContext#	 [ 
 � RowDefinitions
 �� $
��Auto ��� $��* �.+�.  (Microsoft.Windows.Controls.Ribbon.Ribbon  -     Name$ Ribbon��.@�1  +Microsoft.Windows.Controls.Ribbon.RibbonTab  $
��Home��.@�3  -Microsoft.Windows.Controls.Ribbon.RibbonGroup  $��Manager��   GroupSizeDefinitions A  ;Microsoft.Windows.Controls.Ribbon.RibbonGroupSizeDefinition     ControlSizeDefinitions. C  =Microsoft.Windows.Controls.Ribbon.RibbonControlSizeDefinition     	ImageSize$ Large=�   IsLabelVisible .   $ Large=� .   $ Large=� .   $ Large=� .   E  ?Microsoft.Windows.Controls.Ribbon.RibbonGroupSizeDefinitionBase   IsCollapsed . .@�4	  .Microsoft.Windows.Controls.Ribbon.RibbonButton	   	  Label$ 
ErrorTypes�� 	  LargeImageSource$ ../Images\LargeIcon.png������ *ShowErrorManagerCommand+	  $ 
Techniques��$ ../Images\LargeIcon.png������ *ShowTechniqueManagerCommand+	  $ New Plan��$ ../Images\LargeIcon.png������ *ShowPlanManagerCommand+	  $ Clear Current Project��$ ../Images\LargeIcon.png������   $��Language��   .   $ Large=� .    . .@��� -    ��Name$ cbLanguages��$	��150��$��28��$��0, 20, 0, 0q�$
��Left=�$��Center=����� $ SupportedCultures� �� Mode$ OneWay=�  CultureResourcesDS# [ ���� .R��� .+��� ���� *
NativeName+� $��2�� � ColumnDefinitions �� $	��270 ��� $��* ��� $	��270 �.+�� $��0��.+��� $��5, 10q�$��
Parameters��.����  �� Orientation$ Vertical=�.+��� $��20��$��
10,10,10,0q�$��KLOC:��$
��Wrap=��� $��26��$��	10,0,10,0q� �� TextWrapping$
 Wrap=�$��Center=����� *KLOC+$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=��� $��20��$��
10,10,10,0q�$��Error/KLOC:��$
��Wrap=��� $��26��$��	10,0,10,0q�$
 Wrap=�$��Center=����� *ErrorPerKLOC+$ TwoWay=�$ PropertyChanged=��� $��20��$��
10,10,10,0q�$��Number of errors:��$
��Wrap=��� $��26��$��	10,0,10,0q�{�. $
 Wrap=�$��Center=����� *NumberOfErrors+$ TwoWay=�$ PropertyChanged=��� $��20��$��
10,10,10,0q�$��Labor cost:��$
��Wrap=��� $��26��$��	10,0,10,0q�$
 Wrap=�$��Center=����� *	LaborCost+$ TwoWay=�$ PropertyChanged=�� $��1��.+��� $��5, 10q�$ ��Error Types And Techniques��.��� .+��� $	��250��$	��312��$��
0,38,261,0q�$��Right=�$	��Top=����	#FFEFEFEF���� *
ListErrors+���� .R��� $ 
Horizontal=�.+��� $
��Bold"����� *STT+�� $��. ���� ���� *Name+�� $��23��$��
0,15,424,0q�$��Right=�$	��Top=�$��List Error Types���� $	��502��$��
6,38,517,0q�$	��Top=����� *
ListErrors+���� .R��� $��10,10q�$ Vertical=�.+��� $ 
Horizontal=�.+��� $
��Bold"����� *STT+�� $��. ���� ���� *Name+�� $
�� (%)��4
  .BTLViewRibbon.UserControls.SliderTextBoxCustom
  $	��220��$��	10,0,10,0q� 
  ValueSlider �� $ PercentError�$ TwoWay=�$ PropertyChanged=��� ���� $ PercentError�$ TwoWay=�$ PropertyChanged=��� $��23��$��
0,15,168,0q�$��Right=�$	��Top=�$��List Techniques���� $	��250��$	��312��$��0,38,6,0q�$��Right=�$	��Top=����	#FFEFEFEF���� *ListTechniques+���� .R��� $ 
Horizontal=�.+��� $
��Bold"����� *STT+�� $��. ���� ���� *Name+�� $	��505��$	��190��$��	0,355,6,3q�$��Right=�
����ح�$��Information��.��� ���	#FFEFEFEF�� $��20��$��6,17,548,511q�$#��Distribution of defect types:��$
��Wrap=�� $��2��$
��5,10q�
 �� $
��Auto �$	��200���� $��* �.+�� $��0��.+��� $
��Plan��.��&   System.Windows.Controls.DataGrid  $��5q�   AutoGenerateColumns .     Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ *    Header$ 	Technique��� $��1��.+��� $��Result��.��� .+��� .+��� $��20��$��
10,10,10,0q�$��Direct cost:��$
��Wrap=��� $��26��$��	10,0,10,0q�$�� ��$
 Wrap=�$��Center=��� $��20��$��
10,10,10,0q�$��Future cost:��$
��Wrap=��� $��26��$��	10,0,10,0q�$�� ��$
 Wrap=�$��Center=��� $��20��$��
10,10,10,0q�$��Revenue:��$
��Wrap=��� $��26��$��	10,0,10,0q�$�� ��$
 Wrap=�$��Center=��� $��20��$��
10,10,10,0q�$��Total cost:��$
��Wrap=��� $��26��$��	10,0,10,0q�$�� ��$
 Wrap=�$��Center=��� $��20��$��
10,10,10,0q�$��Profit:��$
��Wrap=��� $��26��$��	10,0,10,0q�$�� ��$
 Wrap=�$��Center=��� $��20��$��
10,10,10,0q�$
��ROI:��$
��Wrap=��� $��26��$��	10,0,10,0q�$�� ��$
 Wrap=�$��Center=�