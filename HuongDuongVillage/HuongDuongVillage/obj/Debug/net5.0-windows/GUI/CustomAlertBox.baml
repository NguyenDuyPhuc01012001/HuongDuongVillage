   M S B A M L   `   `   `  ����L  HHuongDuongVillage, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:HuongDuongVillageHuongDuongVillage  5      U QLiveCharts.Wpf, Version=0.9.7.0, Culture=neutral, PublicKeyToken=0bc1f845d1ebb8dfG4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.WpfLiveCharts.Wpf 5      &     HuongDuongVillage.CustomAlertBox   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:HuongDuongVillage     5      Dlvc4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.Wpf     5      _ [MaterialDesignThemes.Wpf, Version=4.2.1.2, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5	      -   5          �Name$  DisplayArea��5
      $	��420��5      $	��160��5      $	��750��5      $	��750��5      
������  � 
ResizeMode$ NoResize=�5       � ShowInTaskbar$ False��5       � SizeToContent$ WidthAndHeight=�5       � Topmost$
 True��5       � WindowStartupLocation$ CenterScreen=�5       � WindowStyle$
 None=�5       � 	Resources 5         MessageBoxButtonStyle �� 
TargetType	 �� Property
 �� Value �� 
TargetType �� CornerRadius ��Name��%�  &	        �� 5   
   " ��6.   .�5      �� 	 � ��

 ���� 6+   �� 5      	 �@��TextAlignment$
 Center=�68   �� 5      	 � ��
 5      �� 5      " ��6&   .R�5      �� $��Border��5      #��z��5      ���	#FFF38413$��1,1,1,1q�5!      $ 10��5"      ._�5#      �� $ contentPresenter��5$   !   #��z��5%   !   #��z��5&   !   #��z��5'   !   #��z��5(   !   #��z��5)   !   5*      5+      5-      5.      5/      .��50      �� ���#fdbb2d$��1q�52   	   $ 0��53   	   ._�54   
   �  � RowDefinitions 55      �� 56      $
��Auto �6    �� 57      $��* �6    �� 58      $
��Auto �6     � ColumnDefinitions 5:      �� 5;      $
��Auto �6#   �� 5<      $��* �6#   .+�5>      �� $��1��5?      $��2��5@      $��0��5A      $��2��5B      
�������5C      �� 5D      $��0��5E      $��0��5F      $��2��5G      ���#fdbb2d5H      � 5I      $��0��5J      $��2��5K      $��40��5L      .+�5M      �� -   5        $��MessageTitle��5N      $��5,1,0,1q�5O      $��Center=�5P      $��16(�5Q      $
��Bold"�5R      
������� �� 
LineHeight$ 22��5T      $��CharacterEllipsis=�5U      5V      �� 5W      -   5        $	��img��5X      $��1��5Y      $��0��5Z      $��50��5[      $��50��5\      $��5q�5]      $
��Fill=�5^      �� 5_      -   5        $��txtMsg��5`      $��1��5a      $��1��5b      $��	10,5,10,5q�5c      $��Center=�5d      $��14(�5e      $ 20��5f      $
��Wrap=�5g      � 5h      -   5         �Name$ grdBtn��5i      $��2��5j      $��0��5k      $��2��5l      .+�5m      �� $��Right=�6    �� Orientation$ 
Horizontal=�69   .+�5o      �� -   5        $��btnOk��5p      $��35��5q      $��70��5r      $	��3,5q�5s      $��Stretch=�5t      $��Center=�5u      $��Center=�5v      $��Center=�5w      ���	#FFF38413$��OK��5z      $��11(�5{      $
��Bold"�5|      
������� �� 	IsDefault$
 True��5~      #��[  5�      �� 5�      -   5        $��btnYes��5�      $��35��5�      $��70��5�      $	��3,5q�5�      $��Stretch=�5�      $��Center=�5�      $��Center=�5�      $��Center=�5�      ���	#FFF38413$	��Yes��5�      $��11(�5�      $
��Bold"�5�      
�������#��[  5�      �� 5�      -   5        $��btnNo��5�      $��35��5�      $��70��5�      $	��3,5q�5�      $��Stretch=�5�      $��Center=�5�      $��Center=�5�      $��Center=�5�      
�������$��No��5�      $��14(�5�      ���	#FFF38413#��[  5�      �� 5�      -	   5        $��	btnCancel��5�      $��35��5�      $��70��5�      $	��3,5q�5�      $��Stretch=�5�      $��Center=�5�      $��Center=�5�      $��Center=�5�      
�������$��Cancel��5�      $��14(�5�      ���	#FFF38413#��[  5�      5�      5�      5�      5�      5�      