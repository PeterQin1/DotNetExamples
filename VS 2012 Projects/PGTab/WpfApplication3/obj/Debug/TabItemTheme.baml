   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5      J FWpfApplication3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WpfApplication3WpfApplication3 5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089a ]DevExpress.Xpf.Core.v12.2, Version=12.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a,   &WpfApplication3.ContentToPathConverter   con-  'WpfApplication3.ContentToPathConverter2 	 conv2  �� 
TargetType<  6DevExpress.Xpf.Utils.Themes.DXTabItemThemeKeyExtension�  �DevExpress.Xpf.Utils.Themes.ThemeKeyExtensionInternalBase`1[[DevExpress.Xpf.Utils.Themes.DXTabItemThemeKeys, DevExpress.Xpf.Core.v12.2, Version=12.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a]]   ResourceKey'  !System.Windows.VisualStateManager   VisualStateGroups%  System.Windows.VisualStateGroup   States   System.Windows.VisualState   
Storyboard g� 	BeginTime g� Duration �� 
TargetName �� TargetProperty	 R� KeyTime
 R� Value  System.Windows.Visibility8  2System.Windows.Media.Animation.EasingColorKeyFrame �� KeyTime �� Value9	  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value �Name ��Name �� CornerRadius �� EndPoint �� 
StartPoint � Color � Offset F�Name �� Stretch � UseLayoutRounding �� 
TargetType �� Property �� Value#
  DevExpress.Xpf.Core.DXTabItem2  ,DevExpress.Xpf.Core.HeaderContainerPresenter  Name,  &DevExpress.Xpf.Core.DXContentPresenter   Content E� IsClosed E� 
StartPoint  �� ElementName!    Default" �� 	Converter# � LayoutTransform$ �� ScaleY% � ColumnDefinitions-  'DevExpress.Xpf.Core.HeaderIconPresenter&  Name' 
  Icon( 
  	IconWidth)   	IconWidth* 
  
IconHeight+   
IconHeight, 
  Header- 
  HeaderTemplate.   ContentTemplate/ ��Name0 �� Triggers1 P� Property2 P� Value3 �� 
TargetName4 �� Color�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     5      ;dx2http://schemas.devexpress.com/winfx/2008/xaml/core  5      Fdxt<http://schemas.devexpress.com/winfx/2008/xaml/core/themekeys  5      Hdxdst<http://schemas.devexpress.com/winfx/2008/xaml/core/themekeys  5      .sys&clr-namespace:System;assembly=mscorlib  5      'localclr-namespace:WpfApplication3  5      %�  &	        &	      (  &     5      $ CloseButtonTemplate=�)(      5i      $ CloseButtonStyle=�)(  �    5o      $ Template=�)(  �    5�      $ Padding=�)(  �    5�      $ ForegroundBrush=�)   5	      6#     5
      6$   �� 5      "  ��6V   .R�5   
   � ���	#00FF00FF 5        5      FocusStates��. 5        Focused��6"     5      	Unfocused��6"   5        5      CommonStates��. 5        
Normal��6"     5      	MouseOver��. 5      �� .��5      T� $ 00:00:00X�6<   $ 00:00:00.0010000D�6Q   $ hover��6m   $ (UIElement.Visibility)�6�   ..�5   "   i� $	 00:00:00��69   
 5   &    5   *   Visible=�6>   5   #   5      �� 5      $ 00:00:00X�6;   $ 00:00:00.0010000D�6P   $
 path��6l   $* $(Shape.Fill).(SolidColorBrush.Color)�6�   .g�5   "     $ 00:00:00��66   $ 	#FF9D0E0E��6I   5      5       5!        5"      Pressed��. 5#      �� .��5$      T� $ 00:00:00X�6<   $ 00:00:00.0010000D�6Q   $ hover��6m   $ (UIElement.Visibility)�6�   ..�5%   "   i� $	 00:00:00��69   
 5&   &    5'   *   	Collapsed=�6@   5)   #   5*      T� 5+      $ 00:00:00X�6<   $ 00:00:00.0010000D�6Q   $ pressed��6m   $ (UIElement.Visibility)�6�   ..�5,   "   i� $	 00:00:00��69   
 5-   &    5.   *   Visible=�6>   50   #   51      �� 52      $ 00:00:00X�6;   $ 00:00:00.0010000D�6P   $
 path��6l   $* $(Shape.Fill).(SolidColorBrush.Color)�6�   .g�53   "     $ 00:00:00��66   $ 	#FF9D0E0E��6I   54      55      56        57      Disabled��. 58      �� .��59      U� $ 00:00:00X�6<   $ 00:00:00.0010000D�6Q   $
 path��6m   $ (UIElement.Opacity)�6�   .\�5:   "   	  $ 00:00:00��67   $
 0.35Q�6J   5;      5<      5=      5>      .+�5@      � $ Button��6   ���	#00000000.+�5A      �� $ hover��6   ���	#FF8EA7C4$ 2��6?   $y�	Collapsed=�6P   ._�5B      �� $ 1��6   $��1q�6.   ��5C      �� 5D      $ 0.5,1&�62   $ 0.5,0&�6C   .��5E   "   � $ 	#FFFFFFFF��6/   $ 0Q�6A   � 5F   "   $ 	#FFE0EEFF��6/   $ 1Q�6A   5G      ._�5I      �� $ 1��6!   $��1q�62   ��5J      �� 5K   "   $ 0.5,1&�66   $ 0.5,0&�6G   .��5L   &   � $ 	#FFF5F9FF��63   $ 0Q�6E   � 5M   &   $ 	#FFD2E3F7��63   $ 1Q�6E   5N   #   5P      5Q      5R      �� 5S      $ pressed��6   ���	#FF8EA7C4$ 2��6A   $y�	Collapsed=�6R   ._�5T      �� $ 1��6   $��1q�6.   ��5U      �� 5V      $ 0.5,1&�62   $ 0.5,0&�6C   .��5W   "   � $ 	#FFDDE8F5��6/   $ 1Q�6A   � 5X   "   $ 	#FFE0EEFF��6/   5Y      ._�5[      �� $ 1��6!   $��1q�62   ��5\      �� 5]   "   $ 0.5,1&�66   $ 0.5,0&�6G   .��5^   &   � $ 	#FFD6E1F1��63   $ 1Q�6E   � 5_   &   $ 	#FFD0DFEF��63   5`   #   5b      5c      5d      F� 5e      $
 path��6   $
 Fill=�6%   ���	#FF6F87A3$��Center=�6E   |�����[�G@�4�@�H@�4р�G �*5�@�H��X5��[�G��X5�@��G@:5��R�G��X5�@ΕG��X5� ��G �*5�@ΕG@�4��R�G@�4�@��G��5��[�G@�4$��6��6�   $��0q�6�    .  $��Center=�6"  $��8��6=  5f      5g      5h      �� 5i      " ��6I   .�5j   
   ��  � �� 6%   C� *  $ CloseButtonTemplate=�+�� 5k   
    � ��$ 14��6"   �� 5l   
    � ��$ 14��6#   5m      �� 5o      "  
 6K   .R�5p   
   � # z 6    5q        5�      LocationStates��. 5�        EmptyLocationState��6"     5�      LocationTopHorizontal��6"     5�      LocationLeftVertical��6"     5�      LocationRightVertical��6"     5�      LocationBottomHorizontal��6"     5�      LocationTopVertical��6"     5�      LocationLeftHorizontal��6"     5�      LocationRightHorizontal��6"     5�      LocationBottomVertical��6"   5�        5�      ViewModeState��. 5�        EmptyViewModeState��6"     5�      NormalViewMode��6"     5�      HoldViewMode��6"     5�      ScrollViewMode��6"   5�      .+�5�        $ headerContainerPresenter��6*   . 5�      � $��0,0,12,0q�6   .+�5�      � .+�5�      � $ borderContainer��6   .+�5�      �� }�.  .+�5�   "   F� $ TabPath��6'   $��1��68   $��0,4,0,0q�6M   ���	#FF3E73C5���	#FFA4BFE6��5�   &   B� 5�   *   .��5�   .   E�  .  $	 1,0&�6J   ��6[   �� $  gridContainer��#" Z! 5�   /   5�   +   # 5�   &   �� 5�   *   $$ -1Q�69   5�   #   5�      �� 5�      $ normal��6%   $��0��65   $��0q�6E   
������ 5�      �� 5�      $ selected��6%   $��0��67   $��0q�6G   
������ 5�      �� 5�      $ hover��6%   $��0��64   $��0q�6D   
������ 5�      5�      � 5�      $ gridContainer��6   $��0,3,3,0q�66   .+�5�      � $ headerContainer��6#   #��z��6<   % 5�   "   �� 5�   &   $
��Auto �67   �� 5�   &   $
��Auto �67   �� 5�   &   $��* �67   �� 5�   &   $
��Auto �67   �� 5�   &   $
��Auto �67   .+�5�   "     $& headerIconPresenter��69   ��.  $��0��6h   # z' 6x   #) z( 5�   D   #+ z* 6l   $��Center=�5�   D   $
��Left=�6_   $��0,0,4,0q�6z   $y�	Collapsed=�6�     5�   "   $
��Bold"�68   ���	#FF0F488D��.  $��2��6s   # z, 6�   #. z- 6�   $��Center=�5�   B   #��z��6]   �� 5�   "   $/ closeButton��6;   ��.  $��4��6P   $��Right=�5�   1   $��Center=�6M   $y�	Collapsed=�6h   $��3,1,-6,0q�5�   �   ��61   C� *  $ CloseButtonStyle=�+6�   5�      5�      5�      5�      5�      5�      0 5�   
   P� 5�      1 �@
 
IsSelected2 .  . �5�      �� $3 TabPath��6)    � �� �	#FFA4BFE66>   �� 5�      $3 TabPath��6+    � �� �	#FF3E73C56@   5�      P� 5�      1 �@J�IsMouseOver2 . . �5�      �� $3 TabPath��6)    � �� �	#FFC4CBDC6>   �� 5�      $3 TabPath��6+    � �� �	#FF3E73C56@   5�      P� 5�      1 �@
 
IsSelected2 . . �5�      �� $3 TabPath��6)    � �� �	#FFD0DFF26>   �� 5�      $3 TabPath��6+    � �� �	#FFD0DFF26@   5�      5�      u�5�      9,3,9,3q�6M   �� 5�      $4 Black��6R   5�      