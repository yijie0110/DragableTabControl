   M S B A M L   `   `   `  ����E  ADragablz, Version=0.0.3.234, Culture=neutral, PublicKeyToken=nullK3clr-namespace:Dragablz.Converters;assembly=DragablzDragablz.Converters  5      U QSystem.Runtime, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a7,clr-namespace:System;assembly=System.RuntimeSystem 5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089S OHandyControl, Version=3.3.0.0, Culture=neutral, PublicKeyToken=45be8712787a1e5b9    3Dragablz.Converters.ShowDefaultCloseButtonConverter #  ShowDefaultCloseButtonConverter   BooleanToVisibilityConverter  HeaderHeight  HeaderButtonWidth  InvisibleThumbStyle  �� 
TargetType �� Property �� Value  ButtonCustom  PrimaryTextBrush �� 
TargetType ��Name J� SnapsToDevicePixels �� CornerRadius �� Path �� RelativeSource	 �� Triggers
 P� Property P� Value �� 
TargetName & "TabablzScrollViewerControlTemplate �Name � ColumnDefinitions � RowDefinitions ��Name �� CanContentScroll �� CanHorizontallyScroll �� CanVerticallyScroll ��Name4  .System.Windows.Automation.AutomationProperties   AutomationId � Cursor �� ScrollableHeight � Maximum � Minimum �� ViewportHeight �� ViewportSize* �� #ComputedVerticalScrollBarVisibility � Value �� Mode �� ScrollableWidth  �� Orientation! �� ViewportWidth," �� %ComputedHorizontalScrollBarVisibility  CanvasItemsControlStyle#   Dragablz.DragablzItemsControl# K� IsItemsHost$ � ActualWidth% � ActualHeight!& �� IsDeferredScrollingEnabled'   ItemsPresenterWidth(   ItemsPresenterHeight  	 UniformGridItemsControlStyle) A� Rows 
 TabItemEdgeStyle   Dragablz.DragablzItem  SecondaryRegionBrush  BorderBrush  RegionBrush* ��Name+ �� ContentStringFormat, �� ContentStringFormat   Dragablz.TabablzControl-   CloseItemCommand. `� 	Converter/ �� AncestorType  ClosePathStyle0 n�Name  TabablzEdgeStyle-  'System.Windows.Input.KeyboardNavigation1   TabNavigation2 ��Name3 ��Name4 �� 	Converter5 ��Name6   HeaderPrefixContent&7   HeaderPrefixContentStringFormat*8   #HeaderPrefixContentTemplateSelector9  Name: K� ZIndex;   HeaderItemTemplate<   HeaderItemsOrganiser=   ItemsOrganiser>   TabIndex)   #Dragablz.TabablzHeaderSizeConverter? �� ElementName@ ��NameA   AddItemCommandB �� StretchC   HeaderSuffixContent&D   HeaderSuffixContentStringFormat*E   #HeaderSuffixContentTemplateSelectorF   DirectionalNavigation  SecondayRegionBrushG P� 
SourceName�� 5      F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     :x,http://schemas.microsoft.com/winfx/2006/xaml     5      6controls'https://handyorg.github.io/handycontrol  5      B
converters3clr-namespace:Dragablz.Converters;assembly=Dragablz  5      6dragablz'http://dragablz.net/winfx/xaml/dragablz   5      7system,clr-namespace:System;assembly=System.Runtime  5      %c%  &	        &	      &	 &     &	 @     &	 Z     &	     7  7  7  &	 n    &	 �
    7  &		 �    &	
 g    7  7  7  7  7   7  7  &	 �    7 
 7  7  7  7  7  7     5      61   �� 5	      6#   X�5
      30Q�6-   X�5      24Q�62   �� 5      "  n�6(   .�5   
   ��  � ��
 ���� 6'   �� 5   
    � �� 5      �� 5      .R�5      � 
������ 6   5      5      5      �� 5      "  ��6!   .�5   
   ��  � �� 6'   Z� �� 5   
    � �� 6(   Z� �� 5   
    � ��8   6'   �� 5   
    � ��$ Center=�67   �� 5   
    � ��$ Center=�65   �� 5   
    � ��$ 0q�6$   �� 5   
    �@�FocusVisualStyle 6-   Z� �� 5    
    � ��$ 0q�6,   �� 5!   
    � ��8  6#   �� 5"   
    � ��8  6"   �� 5#   
    � �� 5$      �� 5%      " ��6"   .R�5&      �� $ Chrome��6   #��z��5'      #��z��5(      #��z��5)      $
 true��5+       5*      �� $+ %(controls:BorderElement.CornerRadius)� �� *TemplatedParent+._�5,      �� #��z��6+   #��z��5-   +   #��z��5.   +   $
��True��5/   +   # z 50   +   51      	 52      P� 53      
 �@J�IsMouseOver$
 True��69   . �54      ��  �@J�Opacity$ .9Q�68   �� 55      $ Chrome��6%    6O   �� $= 7(controls:BackgroundSwitchElement.MouseHoverBackground)� �� *TemplatedParent+ � ��56      P� 57      
 � ��$
 True��67   . �58      ��  �@J�Opacity$ .6Q�68   �� 59      $ Chrome��6%    6O   �� $< 6(controls:BackgroundSwitchElement.MouseDownBackground)� �� *TemplatedParent+ � ��5:      P� 5;      
 � {�$ False��67   . �5<      ��  �@J�Opacity$	 0.4Q�68   5=      5?      5A      5B      �� 5D      " ��6A   .R�5E   
   � $
 Grid��6   #��z��6    5F      �� 5G      $��* �6#   �� 5H      $
��Auto �6#    5J      �� 5K      $��* �6    �� 5L      $
��Auto �6    .+�5N      �� $! PART_ScrollContentPresenter��6%   $��0��5O   %   $��0��5P   %   #��z��5Q   %   # z��5R   %   $ False��5S   %   $ False��5T   %   #��z��5U   %   #��z��5V   %   �� 5W      $ PART_VerticalScrollBar��6   $��1��5X      $��0��5Y      $��0,1,0,0q�5Z      $ VerticalScrollBar��5[      $ Arrow��5\      # z 5]      $ 0Q�5^      # z 5_      #y�z 5`       5a      �� *VerticalOffset+$ OneWay=� �� *TemplatedParent+�� 5b      $ PART_HorizontalScrollBar��6   $��0��5c      $��1��5d      $��36��5e      $��20��5f      $��1,0,0,0q�5g      $ HorizontalScrollBar��5h      $ Arrow��5i      # z 5j      $ 0Q�5k      $  
Horizontal=�5l      # z! 5m      #y�z" 5n       5o      �� *HorizontalOffset+$ OneWay=� �� *TemplatedParent+5p      5q      �� 5s      "   6,   .�5t   
   ��  � ��$
 Left=�60   �� 5u   
    � ��$	 Top=�6.   �� 5v   
    � �� 5w      �� 5x      .R�5y      �� $
# True��6   5z      5|      �� 5}   
    � �� 5~      �� 5      "  6"   .R�5�      �� $��0��6#   $��1��5�   #   #��z$ 5�   #   #��z% 5�   #   $
��Auto=�5�   #   $
& True��5�   #   8��  $��Hidden=�5�   #   .��5�      �� #��z' 6)   #��z( 5�   )   $
��Left=�5�   )   $	��Top=�5�   )   # z 5�   )   5�      5�      5�      5�      �� 5�      "   61   .�5�   
   ��  � ��$
 Left=�60   �� 5�   
    � ��$	 Top=�6.   �� 5�   
    � �� 5�      �� 5�      .R�5�      A� $
# True��6"   $) 1��65   5�      5�      �� 5�   
    � �� 5�      �� 5�      "  6"   .R�5�      �� #��z$ 6%   #��z( 5�   %   $
��Left=�5�   %   $	��Top=�5�   %   # z 5�   %   5�      5�      5�      �� 5�      "   6%   .�5�   
   ��  �@�FocusVisualStyle 6-   Z� �� 5�   
    � ��# �  6'   �� 5�   
    � ��8   6'   �� 5�   
    � ��$ 0,0,1,1q�6,   �� 5�   
    � ��# �  6(   �� 5�   
    � ��$ 0q�6#   �� 5�   
    � ��$ 	10,0,10,0q�6$   �� 5�   
    � ��$ Stretch=�67   �� 5�   
    � ��$ Center=�65   �� 5�   
    �@��Left 6(   �� *X+ �� *Self+�� 5�   
    �@��Top 6'   �� *Y+ �� *Self+�� 5�   
    � ��8  6&   �� 5�   
    � ��$	 180��6%   �� 5�   
    � �� 5�      �� 5�      "  6"   .R�5�      � $ templateRoot��6   $
 true��61    5�      �� 5�      $��* �6/   �� 5�      $
��Auto �6/   .+�5�      �� $ 
mainBorder��6!   $��2��5�   !   $��0q�5�   !   #��z��5�   !   #��z��5�   !   #��z��5�   !   ._�5�      �� $ innerBorder��6%   $��0,0,0,-1q�5�   %   #���  5�   %   $y�	Collapsed=�5�   %   5�      �� 5�      $* contentPresenter��6+   $��0��5�   +   #��z��5�   +   $��Stretch=�5�   +   $��Center=�5�   +   #��z��5�   +   $��Header��5�   +   #, z+ 5�   +   #��z��5�   +   $|�False��5�   +   $
��True��5�   +   # z 5�   +   �� 5�      $��1��6!   8�� $��
-10,0,2,-1q�5�   !   $��Right=�5�   !   
������ #��Z- 5�   !   $|�False��5�   !   8�� ��5�   !   ��  �� *TemplatedParent+y�5�      `� 5�   "   8.  .1�5�   &   �� $ ShowDefaultCloseButton�6.    6L   �� *FindAncestor+"/  �� 5�   &   $ FixedHeaderCount�6.    6F   �� *FindAncestor+"/  �� 5�   &   $ LogicalIndex�6.    6B   �� *TemplatedParent+5�   #   .��5�      F� $��9��6#   $��9��5�   #   #���  5�   #   8�� 5�   #   5�      n� 5�      $0 
PART_Thumb��6    $��1��5�       $��Stretch=�5�       $��Stretch=�5�       $��Stretch=�5�       8�� 5�       5�      	 5�      P� 5�      
 �@ 
IsSelected$
 true��68   . �5�      ��  �@K�ZIndex$ 1��6=   �� 5�      $ innerBorder��6%    � y�$ Visible=�6T   5�      5     5     5     �� 5     "   6%   .�5  
   ��  � ��$ 0q�6$   �� 5  
    � ��# �  6'   �� 5	  
    � ��# �  6(   �� 5
  
    � ��$ 1q�6,   �� 5  
    � ��$ Center=�67   �� 5  
    � ��$ Center=�65   �� 5  
    � ��8   6/   �� 5  
    � �� 5     �� 5     "  6"   .R�5     �� #��z��6   #��z��5     #��z��5     ._�5     � $ templateRoot��6   $
}�true��5     $1 Local=�5     $
 true��5      5     �� 5  "   $2 ColumnDefinition0��63   $
��Auto �6N   �� 5  "   $2 ColumnDefinition1��63   $��* �6N   �� 5  "   $
��Auto �63    5     �� 5  "   $3 RowDefinition0��60   $
��Auto �6H   �� 5   "   $3 RowDefinition1��60   $��* �6H   .+�5#     �� $��PART_HeaderBorder��6%   $��1��5$  %   #��z��5%  %   #���  5&  %   $��0,0,0,1q�5'  %   � 5)     $ HeaderContainerGrid��6#   $��0��5*  #   $��1��5+  #   y�5,  #   �� *IsHeaderPanelVisible+84   5.  "   �� 5/  &   $
��Auto �67   �� 50  &   $
��Auto �67   �� 51  &   $
��Auto �67   �� 52  &   $��* �67   �� 53  &   $2 ColumnMargin��67   $��4 �6M   .+�57  "   �� $ PrefixBorder��6)   $��0��58  )   #��z��59  )   $��0,0,1,0q�5:  )   ._�5;  &   �� $5 PrefixContentControl��65   $��Center=�5<  5   #��z6 5=  5   #+ z7 5>  5   #��z7 5?  5   #��z8 5@  5   5A  #     5D  "   $9 PART_HeaderItemsControl��6@   $��1��5E  @   $: 1��5F  @   #��z��5G  @   #��z; 5H  @   #= z< 5I  @   $> 1��5K  @   8�� ��5J  @   �� *Items+ �� *TemplatedParent+��5N  &   `� 5O  *   . 5P  .     5Q  2   .1�5S  .   �� $ ActualWidth�66    6I   �� *TemplatedParent+�� 5T  .   $ ItemsPresenterWidth�66    6Q   �� *Self+�� 5U  .   $? PrefixContentControl��66   $ ActualWidth�6Y   �� 5V  .   $? DefaultAddButton��66   $ DesiredSize.Width�6U   �� 5W  .   $? SuffixContentControl��66   $ DesiredSize.Width�6Y   �� 5X  .   $? ColumnMargin��66   $ ActualWidth�6Q   5Y  +   5[  #   �� 5^  "   $@ DefaultAddButton��6)   $��2��5_  )   8�� 
������ #��ZA 5b  )   8�� y�5d  )   �� *ShowDefaultAddButton+84  ��5f  &   F� 5g  *   $��12��6/   $��12��5h  /   s���� ��`�w�� ������Ѡ�����Ѡ�    �`4<    �`4<�����    �����    `�w��`4<`�w��`4< L;�Ѡ� L;�Ѡ�`�w�8�� $B Uniform=�5k  /   5m  #   �� 5p  "   $5 SuffixContentControl��61   $��3��5q  1   $��Stretch=�5r  1   $��Center=�5s  1   #��zC 5t  1   #+ zD 5u  1   #��zD 5v  1   #��zE 5w  1   5y     �� 5{     $ contentPanel��6%   $��1��5|  %   $��1��5}  %   #���  5~  %   $��0q�5  %   $F 	Contained=�5�  %   $> 2��5�  %   $1 Local=�5�  %   ._�5�  "   � $ PART_ItemsHolder��6'   $��1��5�  '   $��1��5�  '   $��0q�5�  '   #���  5�  '   5�     5�     5�     	 5�     P� 5�     $G PrefixContentControl��6"    6W   Z� 
 � ��. �5�     �� $ PrefixBorder��6%    � y�$ 	Collapsed=�6U   5�     P� 5�     
 �@ IsHeaderPanelVisible$ False��6B   . �5�     �� $ contentPanel��6%    � ��$ 0,0,0,0q�6Q   5�     P� 5�     
 � {�$ false��67   . �5�     �� $ templateRoot��6%   # � ��6a    � ��5�     P� 5�     
 �@ IsDraggingWindow$
 True��6>   . �5�     �� $ DefaultAddButton��6%    � y�$ 	Collapsed=�6Y   5�     5�     5�     5�     5�     