   M S B A M L   `   `   `  ����c  _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35qPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.InteractivitySystem.Windows.Interactivity  5      ` \RibbonControlsLibrary, Version=4.0.0.11019, Culture=neutral, PublicKeyToken=31bf3856ad364e35tNclr-namespace:Microsoft.Windows.Controls.Ribbon;assembly=RibbonControlsLibrary!Microsoft.Windows.Controls.Ribbon 5      H DBTLViewRibbon, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:BTLViewRibbon.ViewModelsBTLViewRibbon.ViewModels 5      .   (BTLViewRibbon.Views.PlanDetailCreateView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      ^iPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.Interactivity     5      aribbonNclr-namespace:Microsoft.Windows.Controls.Ribbon;assembly=RibbonControlsLibrary     5      <	viewModel&clr-namespace:BTLViewRibbon.ViewModels     5        � Title$  Plan Creation��5      $	��606��5      $	��517��5	      $��13(�5
      .   (System.Windows.Interactivity.Interaction   Triggers 5      /   )System.Windows.Interactivity.EventTrigger  5   
      	EventName$ Closing��6   .   (System.Windows.Interactivity.TriggerBase   Actions. 5      6   0System.Windows.Interactivity.InvokeCommandAction     Command 6$   �� *CloseWindowCommand+5       � 	Resources 5      8  2BTLViewRibbon.ViewModels.PlanDetailCreateViewModel   	viewModel��%   &	          5   
   6.   5      .��5      �  � DataContext# [  6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   .  (Microsoft.Windows.Controls.Ribbon.Ribbon  -   5          Name$ Ribbon��5      $��0��6(   .@�5      1  +Microsoft.Windows.Controls.Ribbon.RibbonTab  $
��Home��6   .@�5      3  -Microsoft.Windows.Controls.Ribbon.RibbonGroup  $��Manager��6%   	   GroupSizeDefinitions	 5       A	  ;Microsoft.Windows.Controls.Ribbon.RibbonGroupSizeDefinition	  
 	  ControlSizeDefinitions.
 5!      C
  =Microsoft.Windows.Controls.Ribbon.RibbonControlSizeDefinition
   
  	ImageSize$ Large=�6A    
  IsLabelVisible . 6S   
  5"      $ Large=�6A    . 6S   
  5#      $ Large=�6A    . 6S   5$      	  5%      E  ?Microsoft.Windows.Controls.Ribbon.RibbonGroupSizeDefinitionBase   IsCollapsed . 6;   .@�5'      4  .Microsoft.Windows.Controls.Ribbon.RibbonButton     Label$ Move Up��6*      LargeImageSource$ ..\Images\LargeIcon.png��6\   ��6:   �� *MoveUpCommand+6\     5(      $ 	Move Down��6*   $ ..\Images\LargeIcon.png��6`   ��6<   �� *MoveDownCommand+6`     5)      $ Delete��6*   $ ..\Images\LargeIcon.png��6[   ��69   �� *DeleteCommand+6[   5*      5+      5,      � 5/   
   $��1��6   $��0,10,0,0q�6    � ColumnDefinitions 50      �� 51      $
��190* �6#   �� 52      $
��Auto �6#   �� 53      $
��239* �6#   .+�56      � $��0��6   .+�57      �� $��0q�6   $��List Techniques��6&   .��58      � .+�59      �� $��0,0,0,0q�6"   ��63   �� *ListTechniques+��5:      �� 5;   "   .R�5<   &   ��  �� Orientation$ 
Horizontal=�61   .+�5=   *   �� $
��Bold"�64   ��6F   �� *STT+�� 5>   *   $��. ��64   �� 5?   *   ��64   �� *Name+5@   '   5A   #    5D        5E   "   $ PreviewMouseDown��61   . 5F   &      6<   �� *!SelectionTechniqueChangeCommand+   CommandParameter 6p   ��  �� Path$ SelectedItem� �� RelativeSource ��  �� Mode$ FindAncestor=� �� AncestorType$ ListBoxL�5G   #   5I      5J      5K      5L      � 5N      $��1��6   $��0,0,0,0q�6#   .+�5O      �� $��75��6   $��23��5P      $��10q�5Q      $	��Top=�5R      $	��Add��5S      ��5T      �� *
AddCommand+5U      �� 5W      $��2��6   $
��Plan��6'   .��5X      � $��2��6   $��0,0,0,0q�6'    5Y      �� 5Z      $��* �6(   �� 5[      $
��Auto �6(   .+�5^      �� $��0��6   ��6+   �� *ListItemPlans+��5_      �� 5`      .R�5a   "   �� $ Vertical=�6-   .+�5b   &   �� $ 
Horizontal=�61   .+�5c   *   �� $��- ��64   $
��Bold"�6>   �� 5d   *   $
��Bold"�6Y   ��64   �� $ Technique.Name�6Y   5e   '   �� 5f   &   $ 
Horizontal=�61   $��20, 4, 0, 4q�6J   .+�5g   *   �� $
��Tx: ��64   �� 5h   *   $��22��62   $	��120��5i   2   ��5j   2   �� *
TxFactor+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�5m   '   5n   #   5o       5r        5s      $ PreviewMouseDown��6-   . 5t   "      68   �� *" SelectionPlanDetailChangeCommand+ 6m   �� $ SelectedItem� �� $ FindAncestor=�$ ListBoxL�5u      5w      5x      5y      5z      5{      5|      