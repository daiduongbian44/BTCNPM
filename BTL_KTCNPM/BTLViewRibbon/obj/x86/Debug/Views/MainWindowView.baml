   M S B A M L   `   `   `  ����c  _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35qPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.InteractivitySystem.Windows.Interactivity  5      H DBTLViewRibbon, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:BTLViewRibbon.UserControlsBTLViewRibbon.UserControls 5      ` \RibbonControlsLibrary, Version=4.0.0.11019, Culture=neutral, PublicKeyToken=31bf3856ad364e35tNclr-namespace:Microsoft.Windows.Controls.Ribbon;assembly=RibbonControlsLibrary!Microsoft.Windows.Controls.Ribbon 5      C&clr-namespace:BTLViewRibbon.ViewModelsBTLViewRibbon.ViewModels 5      (   "BTLViewRibbon.Views.MainWindowView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      ^iPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.Interactivity     5      7my(clr-namespace:BTLViewRibbon.UserControls     5      aribbonNclr-namespace:Microsoft.Windows.Controls.Ribbon;assembly=RibbonControlsLibrary     5      5vm&clr-namespace:BTLViewRibbon.ViewModels     5      -   5        4  .Microsoft.Windows.Controls.Ribbon.RibbonWindow   Name$  RibbonWindow��5      $
��1366��5      $	��768��5      $��13(�5       � Icon$ ../Images/icon.png��5       � WindowStartupLocation$ CenterScreen=�5       � WindowState$ 	Maximized=�5       � Title 5	      ��  �� Path$ TitleMainWindow�   	Resources �� Source# [   � 	Resources 5      2  ,BTLViewRibbon.ViewModels.MainWindowViewModel  	viewModel��%   &	         5   
   6!   5      .��5      � -   5         �Name$ 
LayoutRoot��5      	 � DataContext#	 [ 6   
 � RowDefinitions
 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   .  (Microsoft.Windows.Controls.Ribbon.Ribbon  -   5          Name$ Ribbon��5      .@�5      1  +Microsoft.Windows.Controls.Ribbon.RibbonTab  ��6   �� $ TabHome�# [  .@�5      3  -Microsoft.Windows.Controls.Ribbon.RibbonGroup  ��6%   �� $ GroupManager�# [     GroupSizeDefinitions 5      A  ;Microsoft.Windows.Controls.Ribbon.RibbonGroupSizeDefinition     ControlSizeDefinitions. 5       C  =Microsoft.Windows.Controls.Ribbon.RibbonControlSizeDefinition     	ImageSize$ Large=�6A      IsLabelVisible . 6S     5!      $ Large=�6A    . 6S     5"      $ Large=�6A    . 6S     5#      $ Large=�6A    . 6S   5$        5%      E  ?Microsoft.Windows.Controls.Ribbon.RibbonGroupSizeDefinitionBase   IsCollapsed . 6;   .@�5'      4	  .Microsoft.Windows.Controls.Ribbon.RibbonButton	   	  LargeImageSource$ ../Images\LargeIcon.png��5*   *   ��5'   *   �� *ShowErrorManagerCommand+ 	  Label 5(   *   �� $ ButtonErrorTypes�# [  5*   *   	  5+      $ ../Images\LargeIcon.png��5.   *   ��5+   *   �� *ShowTechniqueManagerCommand+ 5,   *   �� $ ButtonTechniques�# [  5.   *   	  5/      $ ../Images\LargeIcon.png��52   *   ��5/   *   �� *ShowPlanManagerCommand+ 50   *   �� $ ButtonNewPlan�# [  52   *   	  54      $ ../Images\LargeIcon.png��57   *   ��54   *   �� *SaveDataCommand+ 55   *   �� $ ButtonSaveData�# [  57   *   58        5<      ��6%   �� $ GroupEstimation�# [  .@�5=      	  $ ../Images\LargeIcon.png��5@   *   ��5=   *   �� *EstimateProjectCommand+ 5>   *   �� $ ButtonEstimation�# [  5@   *   	  5A      $ ../Images\LargeIcon.png��5D   *   ��5A   *   �� *ClearCurrentProjectCommand+ 5B   *   �� $ ButtonClearCurrent�# [  5D   *   5E        5G      ��6%   �� $ GroupLanguage�# [   5I        . 5J        $ Large=�6A    . 6S   5K        5L       . 6;   .@�5O      �� -   5         ��Name$ cbLanguages��5O      $	��150��5P      $��28��5Q      $��0, 20, 0, 0q�5R      $
��Left=�5S      $��Center=�5W      ��5T      �� $ SupportedCultures� �� Mode$ OneWay=�  CultureResourcesDS# [ ��5X      �� 5Y      .R�5Z   "   �� .+�5[   &   �� ��60   �� *
NativeName+5\   #   5]      5_      5`      5a      5b      � 5d   
   $��2��6    � ColumnDefinitions 5e      �� 5f      $	��270 �6#   �� 5g      $��* �6#   �� 5h      $	��270 �6#   .+�5k      � $��0��6   .+�5l      �� $��5, 10q�6   ��6*   �� $ GBParameter�# [  .��5m      ��  �� Orientation$ Vertical=�6!   .+�5n      �� $��20��6$   $��
10,10,10,0q�5o   $   $��KLOC:��5p   $   $
��Wrap=�5q   $   �� 5r      $��26��6"   $��	10,0,10,0q�5s   "    �� TextWrapping$
 Wrap=�5w   "   $��Center=�5x   "   ��5t   "   �� *KLOC+$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�5x   "   �� 5z      $��20��6$   $��
10,10,10,0q�5{   $   $��Error/KLOC:��5|   $   $
��Wrap=�5}   $   �� 5~      $��26��6"   $��	10,0,10,0q�5   "   $
 Wrap=�5�   "   $��Center=�5�   "   ��5�   "   �� *ErrorPerKLOC+$ TwoWay=�$ PropertyChanged=�5�   "   �� 5�      $��20��6$   $��
10,10,10,0q�5�   $   $
��Wrap=�5�   $   ��5�   $   �� $ NumberOfErrors�# [  5�   $   �� 5�      $��26��6"   $��	10,0,10,0q�5�   "    �� 
IsReadOnly . $
 Wrap=�5�   "   $��Center=�5�   "   ��5�   "   �� *NumberOfErrors+$ TwoWay=�$ PropertyChanged=�5�   "   �� 5�      $��20��6$   $��
10,10,10,0q�5�   $   $
��Wrap=�5�   $   ��5�   $   �� $ 	LaborCost�# [  5�   $   �� 5�      $��26��6"   $��	10,0,10,0q�5�   "   $
 Wrap=�5�   "   $��Center=�5�   "   ��5�   "   �� *	LaborCost+$ TwoWay=�$ PropertyChanged=�5�   "   5�      5�      5�      � 5�      $��1��6   .+�5�      �� $��5, 10q�6   ��6*   �� $ GBErrorTypeAndTechnique�# [  .��5�      � .+�5�      �� $	��250��6"   $	��312��5�   "   $��
0,38,261,0q�5�   "   $��Right=�5�   "   $	��Top=�5�   "   ���	#FFEFEFEF��5�   "   �� *
ListErrors+��5�      �� 5�   "   .R�5�   &   �� $ 
Horizontal=�61   .+�5�   *   �� $
��Bold"�64   ��6F   �� *STT+�� 5�   *   $��. ��64   �� 5�   *   ��64   �� *Name+5�   '   5�   #   .
   (System.Windows.Interactivity.Interaction 
  Triggers 5�      /   )System.Windows.Interactivity.EventTrigger  5�   "      	EventName$ PreviewMouseDown��61   .   (System.Windows.Interactivity.TriggerBase   Actions. 5�   &   6   0System.Windows.Interactivity.InvokeCommandAction     Command 6<   �� *SelectionErrorChangeCommand+   CommandParameter 6l   �� $ SelectedItem� �� RelativeSource ��   �� Mode$  FindAncestor=�! �� AncestorType$! ListBoxL�5�   #   5�      �� 5�      $��23��6$   $��
0,15,424,0q�5�   $   $��Right=�5�   $   $	��Top=�5�   $   ��5�   $   �� $ ListErrorTypes�# [  �� 5�      $	��502��6"   $��
6,38,517,0q�5�   "   $	��Top=�5�   "   ��5�   "   �� *
ListErrors+��5�      �� 5�   "   .R�5�   &   �� $��10,10q�61   $ Vertical=�6@   .+�5�   *   �� $ 
Horizontal=�65   .+�5�   .   �� $
��Bold"�68   ��6J   �� *STT+�� 5�   .   $��. ��68   �� 5�   .   ��68   �� *Name+�� 5�   .   $
�� (%)��68   �� 5�   .   $
��____��68   �� 5�   .   ��68   �� *Count+�� 5�   .   $�� Errors��68   5�   +   � 5�   *   $	��250��6/   $��0,5,0,5q�6>   .+�5�   .   �� $��23��65   $��0,0,35,0q�5�   5   " �� IsSnapToTickEnabled" .  # � Maximum$	# 100Q�5�   5   $ � Minimum$$ 0Q�5�   5   % �� TickFrequency$% 5Q�5�   5   & �� TickPlacement$& BottomRight=�5�   5   ' � Value' 5�   5   �� $ PercentError�$ TwoWay=�$ PropertyChanged=��� 5�   .   $��32��66   $��23��5�   6   $��0,0,0,0q�5�   6   $��Right=�5�   6    . ��5�   6   �� *PercentError+5�   +   5�   '   5�   #   5�      �� 5�      $��23��6$   $��
0,15,168,0q�5�   $   $��Right=�5�   $   $	��Top=�5�   $   ��5�   $   �� $ ListTechniques�# [  �� 5�      $	��250��6"   $	��312��5�   "   $��0,38,6,0q�5�   "   $��Right=�5�   "   $	��Top=�5�   "   ���	#FFEFEFEF��5�   "   �� *ListTechniques+��5�      �� 5�   "   .R�5�   &   �� $ 
Horizontal=�61   .+�5�   *   �� $
��Bold"�64   ��6F   �� *STT+�� 5�   *   $��. ��64   �� 5�   *   ��64   �� *Name+5   '   5  #    5       5  "   $ PreviewMouseDown��61   . 5  &      6<   �� *!SelectionTechniqueChangeCommand+ 6p   �� $ SelectedItem� �� $  FindAncestor=�$! ListBoxL�5  #   5	     �� 5
     $	��505��6#   $	��190��5  #   $��	0,355,6,3q�5  #   $��Right=�5  #   
����ح���5  #   �� $ GBInformation�# [  .��5     � 
�������.+�5  "   �� $��87��6,   $��22��5  ,   $��	23,14,0,0q�5  ,   $
��Left=�5  ,   $	��Top=�5  ,   $��Error��5  ,   �� 5  "   $	��206��6*   $��26��5  *   $��	99,12,0,0q�5  *   $
��Left=�5  *   $	��Top=�5  *    . ��5  *   �� $- 'TERelationshipEntitySelected.Error.Name�$ PropertyChanged=�$ TwoWay=��� 5!  "   $��87��6,   $��22��5"  ,   $��	23,48,0,0q�5#  ,   $
��Left=�5$  ,   $	��Top=�5%  ,   $��	Technique��5&  ,   �� 5'  "   $	��206��6*   $��26��5(  *   $��	99,46,0,0q�5)  *   $
��Left=�5*  *   $	��Top=�5+  *    . ��5-  *   �� $1 +TERelationshipEntitySelected.Technique.Name�$ PropertyChanged=�$ TwoWay=��� 50  "   $��87��6,   $��22��51  ,   $��	23,84,0,0q�52  ,   $
��Left=�53  ,   $	��Top=�54  ,   $��Function��55  ,   �� 57  "   $��50��6,   $��22��58  ,   $��185,118,0,0q�59  ,   $
��Left=�5:  ,   $	��Top=�5;  ,   $��Param��5<  ,   �� 5=  "   $��65��6*   $��26��5>  *   $��240,116,0,0q�5?  *   $
��Left=�5@  *   $	��Top=�5A  *   ��5B  *   �� $7 1TERelationshipEntitySelected.Function.ParamFactor�$ PropertyChanged=�$ TwoWay=��� 5F  "   $	��206��6+   $��26��5G  +   $��	99,81,0,0q�5H  +   $
��Left=�5I  +   $	��Top=�5J  +   ( �� DisplayMemberPath$
( Name��5K  +   ) �� SelectedValuePath$
) Name��5P  +   ��5L  +   �� *ListFunctions+* �� SelectedValue* 5M  +   �� $0 *TERelationshipEntitySelected.Function.Name�$ PropertyChanged=�$ OneWay=� 5Q  &     5R  *   $ SelectionChanged��69   . 5S  .      6D   �� *(&ComboboxFunctionSelectionChangeCommand+ 6   �� $ SelectedValue� �� $  FindAncestor=�$! ComboBoxL�5T  +   5V  #   �� 5W  "   $	��176��6(   $��98��5X  (   $��
311,68,0,0q�5Y  (   $
��Left=�5Z  (   $	��Top=�5[  (   $��Uniform=�5_  (   ��5\  (   �� $9 3TERelationshipEntitySelected.Function.ImageFunction�$ PropertyChanged=�$ OneWay=�5_  (   �� 5`  "   $��58��6,   $��22��5a  ,   $��
23,118,0,0q�5b  ,   $
��Left=�5c  ,   $	��Top=�5d  ,   $��Vx��5e  ,   �� 5f  "   $��61��6*   $��26��5g  *   $��
99,116,0,0q�5h  *   $
��Left=�5i  *   $	��Top=�5j  *   ��5k  *   �� $% TERelationshipEntitySelected.Vx�$ PropertyChanged=�$ TwoWay=�5n     5o     �� 5p     $	��228��6$   $��20��5q  $   $��
6,14,0,514q�5r  $   $
��Left=�5s  $   $
��Wrap=�5v  $   ��5t  $   �� $ DistributionDefect�# [  5v  $   5w     5y     5z     � 5|     $��2��6   $
��5,10q�6#   
 5}     �� 5~     $
��Auto �6$   $	��200��62   �� 5     $��* �6$   .+�5�     � $��0��6   .+�5�     �� ��6   �� $ GBPlan�# [  .��5�     &   System.Windows.Controls.DataGrid  $��5q�6#   +   AutoGenerateColumns+ .  
�������,   
IsReadOnly, . ��5�  #   �� *ListItemPlans+-   Columns- 5�     0  *System.Windows.Controls.DataGridTextColumn  5�  "   ,  &System.Windows.Controls.DataGridColumn.   Width5  /System.Windows.Controls.DataGridLengthConverter$. 2* 65   /   Header$/ 	Technique��5�  5   1  +System.Windows.Controls.DataGridBoundColumn0   Binding0 5�  5   �� $ Technique.Name�5�  5     5�  "   $. * 65   $/ Tx��5�  5   0 5�  5   �� *
TxFactor+5�  5   5�     5�     5�     � 5�     $��1��6   .+�5�     �� ��6   �� $ GBResult�# [  .��5�     � .+�5�     �� .+�5�  "   �� $��20��6,   $��
10,10,10,0q�5�  ,   $
��Wrap=�5�  ,   ��5�  ,   �� $ 
DirectCost�# [  5�  ,   �� 5�  "   $��26��6*   $��	10,0,10,0q�5�  *    . $
 Wrap=�5�  *   $��Center=�5�  *   ��5�  *   �� *
DirectCost+$ TwoWay=�$ PropertyChanged=�5�  *   �� 5�  "   $��20��6,   $��
10,10,10,0q�5�  ,   $
��Wrap=�5�  ,   ��5�  ,   �� $ 
FutureCost�# [  5�  ,   �� 5�  "   $��26��6*   $��	10,0,10,0q�5�  *    . $
 Wrap=�5�  *   $��Center=�5�  *   ��5�  *   �� *
FutureCost+$ TwoWay=�$ PropertyChanged=�5�  *   �� 5�  "   $��20��6,   $��
10,10,10,0q�5�  ,   $
��Wrap=�5�  ,   ��5�  ,   �� $ Revenue�# [  5�  ,   �� 5�  "   $��26��6*   $��	10,0,10,0q�5�  *    . $
 Wrap=�5�  *   $��Center=�5�  *   ��5�  *   �� *	Revenue+$ TwoWay=�$ PropertyChanged=�5�  *   �� 5�  "   $��20��6,   $��
10,10,10,0q�5�  ,   $
��Wrap=�5�  ,   ��5�  ,   �� $ 	TotalCost�# [  5�  ,   �� 5�  "   $��26��6*   $��	10,0,10,0q�5�  *    . $
 Wrap=�5�  *   $��Center=�5�  *   ��5�  *   �� *	TotalCost+$ TwoWay=�$ PropertyChanged=�5�  *   �� 5�  "   $��20��6,   $��
10,10,10,0q�5�  ,   $
��Wrap=�5�  ,   ��5�  ,   �� $ Profit�# [  5�  ,   �� 5�  "   $��26��6*   $��	10,0,10,0q�5�  *    . $
 Wrap=�5�  *   $��Center=�5�  *   ��5�  *   �� *Profit+$ TwoWay=�$ PropertyChanged=�5�  *   �� 5�  "   $��20��6,   $��
10,10,10,0q�5�  ,   $
��Wrap=�5�  ,   ��5�  ,   �� $	 ROI�# [  5�  ,   �� 5�  "   $��26��6*   $��	10,0,10,0q�5�  *    . $
 Wrap=�5�  *   $��Center=�5�  *   ��5�  *   �� *ROI+$ TwoWay=�$ PropertyChanged=�5�  *   5�     5�     5�     5�     5�     5�     5�     5�     