   M S B A M L   `   `   `  ����L  HHuongDuongVillage, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:HuongDuongVillageHuongDuongVillage  5      U QLiveCharts.Wpf, Version=0.9.7.0, Culture=neutral, PublicKeyToken=0bc1f845d1ebb8dfG4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.WpfLiveCharts.Wpf 5          HuongDuongVillage.FormCEO   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:HuongDuongVillage     5      Dlvc4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.Wpf     5      _ [MaterialDesignThemes.Wpf, Version=4.2.1.2, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5
      -   5          �Name$  DisplayArea��5      $
��1083��5      $	��733��5       � 
ResizeMode$ NoResize=�5       � WindowStartupLocation$ CenterScreen=�5       � WindowStyle$
 None=�5       � 	Resources 5         MenuOpen �� 
TargetName �� TargetProperty9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value  	MenuClose  NavigateBar	 �� Color  Top  Add  TextInNavigate  	TextOnTop��%s  &	        &	 �     &	 �    &	 �    &	 �    &	 �    &	     �� 5   
   .��5      U� $ GridMenu��6,   $ (FrameworkElement.Width)�6M   .\�5        $ 0��6'   $ 60Q�63     5      $ 0:0:0.5��6'   $	 200Q�69   5      5      �� 5   
   .��5      U� $ GridMenu��6,   $ (FrameworkElement.Width)�6M   .\�5        $ 0��6'   $	 200Q�63     5      $ 0:0:0.5��6'   $ 60Q�69   5      5      �� 5   
   $	 #1a2a6c��6.   �� 5   
   $	 #fdbb2d��6&   �� 5    
   $	 #fdbb2d��6&   �� 5!   
   $	 White��61   �� 5"   
   $	 #403B4A��6,   5#      
 � Triggers
 5%      :� 5&   
    :� RoutedEvent$ ButtonBase.Click��6    :� 
SourceName$ ButtonOpenMenu��66   .[�5'      �� #��[  6   5(      :� 5)   
   $ ButtonBase.Click��6   $ ButtonCloseMenu��66   .[�5*      �� #��[ 6   5+      .��5-      �� 
���   �$��2q�6!   ._�5/   
   � .+�51      � -   5         �Name$ GridMain��51      $��	60,60,0,0q�6%   .+�53      � -   5        $ GridAssistant��53      5F      � 5G      -   5        $ GridPrincipal��5H      $
��1020��5I      $	��676��5J      $��Center=�5K      $��Center=�5L       J� RenderTransformOrigin$ 0.5,0.5&�5M       � RowDefinitions 5N      �� 5O      $	��27* �6(   �� 5P      $
��142* �6(   .+�5R      � -   5        $ TopModifyContainer��5R      $��0��67    � ColumnDefinitions 5S      �� 5T      $��2* �6/   �� 5U      .+�5X      � -   5        $ SearchBoxContainer��5Y      $��0��5Z      $	��400��5[      $��45��5\      $��
0,10,10,10q�5]      $��Center=�5^      $��Center=�5_      .+�5`      �� 
������� �� CornerRadius$ 20��6<   ._�5a   "   ��  �� Orientation$ 
Horizontal=�6-   .+�5b   &   !   HuongDuongVillage.SearchBox  $��Center=�66   �� 5c   &   -   5         ��Name$ 	txbSearch��5d   %   $	��350��5e   %   $
��Left=�5f   %   $��Center=�5g   %   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Type to search��5h   %   $��15(�5i   %   $
��Bold"�5j   %   5k   %   5l   #   5m      5n      5o      � 5q      -   5        $ BottomModifyContainer��5r      $��1��5s      $
��1010��5t       5u      �� 5v      $	��49* �6,   �� 5w      $
��519* �6,   .+�5y      � -	   5        $ ManagerFieldHolder��5y      $��0��6;   5z      � 5{      -
   5        $ ProgressBarContainer��5{       K� ZIndex$
 1000��6=   $y�Hidden=�6Q   $��1��6e   ��5}      �� 5~   "    �� Opacity$ .5Q�62   $	 Black��6?   .+�5�      �� $��Center=�5�      $��Stretch=�5�      $ 
Horizontal=�5�      .+�5�   "   � $��60��5�      $��60��5�      
������� � IsIndeterminate$
 True��5�       % !MaterialDesignCircularProgressBar#��[ 5�       � Value$ 35Q�5�      5�      5�      �� 5�      -   5         ��Name$ CardContainer��5�   '   $��1��6>   .��5�      �� -   5         ��Name$ 
ListHolder��5�   )   $ Vertical=�6=   5�      5�      5�      5�      5�      � 5�      $��60��5�      $	��Top=�5�      #���  5�       J� Effect 5�      3  -System.Windows.Media.Effects.DropShadowEffect  5�         
BlurRadius$ 1Q�5�         ShadowDepth$ 1Q�5�         Color$ 	#FFACACAC��5�      .+�5�      �� $��Center=�5�      $��Center=�5�      $��50(�5�      $
��Bold"�5�      #���  5�       K� Capitals$ AllSmallCaps=�5�      $	��CEO��5�      �� 5�      $��Right=�6   $ 
Horizontal=�69   .+�5�      �� -   5          ��Name$  tblName��5�      $��Center=�5�      $��18(�5�      #���  5�      $�� Admin��5�      '  !MaterialDesignThemes.Wpf.PopupBox  5�      $��5q�5�      #���  5�      !   PlacementMode$! BottomAndAlignRightEdges=�5�      "   	StaysOpen$
" True��5�      #   PopupContent.# 5�      �� $	��160��6%   .+�5�      �� -   5        $ ��Name$$ 
InfoButton��5�      $��5q�5�      $��Center=�5�      $��Center=�5�      % � Cursor$
% Hand��5�      .��5�   "   �� $��Center=�6-   $ 
Horizontal=�6H   .+�5�   &   '  !MaterialDesignThemes.Wpf.PackIcon  $
��auto��5�   %   $
��auto��5�   %   $	��5,0q�5�   %   $��Center=�5�   %   #���  5�   %   &   Kind$& 
InfoCircle=�5�   %   �� 5�   &   $
��auto��5�   %   $��Center=�5�   %   $��14(�5�   %   $��
Info Staff��5�   %   5�   #   5�      �� 5�      -   5        $��ChangepasswordButton��5�      $��5q�5�      $��Center=�5�      $��Center=�5�      $
% Hand��5�      .��5�   "   �� $ 
Horizontal=�6-   .+�5�   &     $
��auto��5�   %   $
��auto��5�   %   $	��5,0q�5�   %   $��Center=�5�   %   #���  5�   %   $& PasswordReset=�5�   %   �� 5�   &   $
��auto��5�   %   $��Center=�5�   %   $��14(�5�   %   $��Change password��5�   %   5�   #   5�      �� 5�      �� 5�      -   5        $$ LogoutButton��5�      $��5q�5�      $��Center=�5�      $��Center=�5�      $
% Hand��5�      .��5�   "   �� $ 
Horizontal=�6-   .+�5�   &     $
��auto��5�   %   $
��auto��5�   %   $	��5,0q�5�   %   $��Center=�5�   %   #���  5�   %   $& Logout=�5�   %   �� 5�   &   $
��auto��5�   %   $��Center=�5�   %   $��14(�5�   %   $��Logout��5�   %   5�   #   5�      5�      5�      5�      5�      � 5      -   5        $ GridMenu��5     $��65��5     $
��Left=�5     #���  5      5       5     $ 2Q�5     $ 1Q�5     $ 	#FFAEAEAE��5	     .+�5     �� .+�5     � $	��160��5     
�������$ 0.5,0.5&�5     z�5     V� 5     .~�5  "   �� �� 5  "   �� 5  "   T� 5  "   5     .+�5     �� -   5        $$ ButtonOpenMenu��5     $��60��5     $��60��5     $��Right=�5     $	��Top=�5       0 ,MaterialDesignFloatingActionMiniAccentButton#��[ 5$     ��5!     Z� ��5"     Z� .��5%       $��25��5&     $��25��5'     #���  5(     $
& Menu=�5)     5*     �� 5+     -   5        $$ ButtonCloseMenu��5,     $��60��5-     $��60��5.     $��Right=�5/     $	��Top=�50     #��[ 54     $y�	Collapsed=�55     ��51     Z� ��52     Z� .��56       $��25��57     $��25��58     #���  59     $& 	ArrowLeft=�5:     5;     �� 5<     $��80��6    $��Bottom=�6,   5=     �� 5>     -   5        ' ��Name$' ListViewMenu��5?     $��Disabled=�5A     .@�5C     �� $	��60 ��6(   ���	#FFDA1B1B.��5D     �� $ 
Horizontal=�6)   .+�5E  "     $��25��5F  !   $��25��5G  !   $��10q�5H  !   $��Center=�5I  !   #���  5J  !   $& ChartAreaspline=�5K  !   �� 5L  "   $��20,10q�5M  !   #���  5N  !   $��Report��5O  !   5P     5Q     �� 5R     $	��60 ��6'   ���	#FFDA1B1B.��5S     �� $ 
Horizontal=�6)   .+�5T  "     $��25��5U  !   $��25��5V  !   $��10q�5W  !   $��Center=�5X  !   #���  5Y  !   $	& Man=�5Z  !   �� 5[  "   $��20,10q�5\  !   $��Center=�5]  !   #���  5^  !   $��Staff��5_  !   5`     5a     �� 5b     $	��60 ��6'   ���	#FFDA1B1B.��5c     �� $ 
Horizontal=�6)   .+�5d  "     $��25��5e  !   $��25��5f  !   $��10q�5g  !   $��Center=�5h  !   #���  5i      $& FileDocument=�5j  !   �� 5k  "   $��20,10q�5l  !   $��Center=�5m  !   #���  5n  !   $��Document��5o  !   5p     5q     �� 5r     $	��60 ��5s     ���#F28705.��5u     �� $ 
Horizontal=�6)   .+�5v  "     $��25��5w  %   $��25��5x  %   $��10q�5y  %   $��Center=�5z  %   #���  5{  %   $& DoorOpen=�5|  %   �� 5}  "   $��20,10q�5~  %   $��Center=�5  %   #���  5�  %   $
��Room��5�  %   5�     5�     �� 5�     $	��60 ��5�     ���#F28705.��5�     �� $ 
Horizontal=�6)   .+�5�  "   (� .��5�  &   �� $��25��5�  )   $��25��5�  )   $��10q�5�  )   .+�5�  *   F� ����� � @KL ׀�� ��j ��� �� Ӏ�� @yn @� ��q ��� Wu �0� �� @o@p�� @o@ $� ���-  $� ���- p�� �P\  �� @k� Wu ��2� ��q ��� @yn ��� ��j � � @KL ��� �� ���O��!р� ��!р� @fр�O@fр�O��!	#���  6�   5�  '   5�  #   �� 5�  "   $��20,10q�5�  %   $��Center=�5�  %   #���  5�  %   $��Service��5�  %   5�     5�     �� 5�     $	��138��6$   �� 5�     $��Center=�5�     $��Center=�5�     $
��Bold"�5�     #���  5�     $��v1.0.0��5�     5�     5�     5�     5�     5�     5�     