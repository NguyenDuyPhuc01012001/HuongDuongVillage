   M S B A M L   `   `   `  ����L  HHuongDuongVillage, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:HuongDuongVillage.GUIHuongDuongVillage.GUI  5      &     HuongDuongVillage.ManageDocument   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:HuongDuongVillage.GUI     5      _ [MaterialDesignThemes.Wpf, Version=4.2.1.2, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5        � Title$  ManageDocument��5	      $	��900��5
      $	��600��5       � 
ResizeMode$ NoResize=�5       � WindowStartupLocation$ CenterScreen=�5       � WindowStyle$
 None=�5      .��5      �� 
����������	#FFF38413$��2q�5   	    �� CornerRadius$ 10��5   	   ._�5   
   �  � ColumnDefinitions 5      �� 5      �� 5      $
��2.5* �6#   .+�5      � -   5         �Name$ vilageInformation��5      $��Center=�6.   .+�5      �� $��/GUI/village_logo.png��6   5      � 5      -   5        $ gridInfo��5      $��1��5       $��0,20,0,0q�5!       � RowDefinitions 5"      �� 5#      $��* �6$   �� 5$      $��4* �6$   �� 5%      $��* �6$    5'      �� 5(      �� 5)      $��5* �6'   .+�5+      �� -   5         ��Name$ 
lblMessage��5,      $��0��5-      $��Right=�5.      $��Center=�5/      $��Title��50      $��18(�51      $
��Bold"�52      
���   �53      � 54      -   5        $ 
grdMessage��55      $��1��56      $��20,0,0,0q�57      .+�58      �� -   5        	 ��Name$	 
recMessage��59      $	��450��5:      $��40��5;      $
��Left=�5<      
 �� RadiusX$
 5��5=       �� RadiusY$ 5��5>      
�������5?      �� 5@      -   5         ��Name$ 
txbMessage��5A      $��10q�5D      $
��Left=�5E      $��Center=�5F      $
��Left=�5G      $��Center=�5H      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Title��5I      $��0q�5J      $��14(�5K      $
��Bold"�5L       �� MaxLines$ 1��5M      ��5B      �� *ActualWidth+ �� ElementName$ 
recMessage����5C      �� *ActualHeight+$ 
recMessage��5M      5N      �� 5O      -   5        $ lblDocument��5P      $��1��5Q      $	��Top=�5S      $��Content��5T      ��5R      �� *HorizontalAlignment+$ 
lblMessage����5U      �� *
FontSize+$ 
lblMessage����5V      �� *
FontWeight+$ 
lblMessage����5W      �� *
Foreground+$ 
lblMessage��� 5X      -   5        $ grdDocument��5Y      $��1��5Z      $��1��5[      ��5\      �� *ActualWidth+$ 
recMessage����5]      �� *Margin+$ 
grdMessage����5^      �� *HorizontalAlignment+$ 
recMessage��.+�5_      �� -	   5        $	 recDocument��5`      ��5a      �� *ActualWidth+$ 
recMessage����5b      �� *Margin+$ 
recMessage����5c      �� *HorizontalAlignment+$ 
recMessage��
 5d      �� *	RadiusX+$ 
recMessage�� 5e      �� *	RadiusY+$ 
recMessage����5f      �� *Stroke+$ 
recMessage���� 5g      -
   5        $ txbDocument��5h      $��10q�5j      $
��Left=�5k      $ Content��5m       �� AcceptsReturn$
 True��5n       �� TextWrapping$
 Wrap=�5r      " �� VerticalScrollBarVisibility$
 Auto=�5s      ��5i      �� *ActualWidth+$ 
recMessage����5l      �� *HorizontalContentAlignment+$ 
txbMessage����5o      �� *BorderThickness+$ 
txbMessage����5p      �� *
FontSize+$ 
txbMessage����5q      �� *
FontWeight+$ 
txbMessage��5s      5t      � 5u      -   5        $ grdSelection��5v      $��7��5w      $��1��5x      $
��Left=�5{      $��Center=�5|      ��5y      �� *ActualWidth+$ 
recMessage����5z      �� *Margin+$ 
grdMessage�� 5}      �� 5~      �� 5      �� 5�      .+�5�      �� -   5         ��Name$ 
btnConfirm��5�      $��0��5�      +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 10��5�      ���	#FFF38413$��Confirm��5�      $��11(�5�      $
��Bold"�5�      
������� !  MaterialDesignFlatMidBgButton#��[  5�      �� 5�      -   5        $ 	btnCancel��5�      $��2��5�      $ 10��5�      $��Cancel��5�      $��11(�5�         MaterialDesignOutlinedButton#��[ 5�      ��5�      �� *
Foreground+$ 
btnConfirm����5�      �� *
FontWeight+$ 
btnConfirm����5�      �� *
Background+$ 
btnConfirm��5�      5�      5�      5�      5�      5�      