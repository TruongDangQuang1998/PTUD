   M S B A M L   `   `   `  ����H  DDangKyHocPhan, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:DangKyHocPhanDangKyHocPhan  5   	   9!clr-namespace:DangKyHocPhan.ViewsDangKyHocPhan.Views  5   	       DangKyHocPhan.MainWindow   5   	   b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:DangKyHocPhan     5   	   4local1!clr-namespace:DangKyHocPhan.Views     5   	    
  MainVM  � DataContext#  [  5
   	    � Title$ Đăng ký học phần��5   	    � WindowState$ 	Maximized=�6#    � 	Resources 5        	CloseMenu �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value  OpenMenu��%\  &	       &	 �    �� 5      .��5      U� $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.X)�60   $ GridMenu��6�   .\�5        $ 0��6+   $	 250Q�67     5      $ 0:0:0.5��6+   $ 0Q�6=   5      U� 5      $ (UIElement.Opacity)�60   $ GridBackground��6`   .\�5        $ 0��6+   $ 1Q�67     5      $ 0:0:0.5��6+   $ 0Q�6=   5      5      �� 5      .��5      U� $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.X)�60   $ GridMenu��6�   .\�5        $ 0��6+   $ 0Q�67     5      $ 0:0:0.5��6+   $	 250Q�6=   5      U� 5      $ (UIElement.Opacity)�60   $ GridBackground��6`   .\�5        $ 0��6+   $ 0Q�67     5      $ 0:0:0.5��6+   $ 1Q�6=   5      5       5!       � Triggers 5"   
   :� 5#      	 :� RoutedEvent$	 ButtonBase.Click��6   
 :� 
SourceName$
 ButtonClose��6:   .[�5$      �� -   5         ��Name$ CloseMenu_BeginStoryboard��5$   "   #��[ 6E   5%      :� 5&      $	 ButtonBase.Click��6   $
 
ButtonOpen��6:   .[�5'      �� #��[ 6"   5(      .��5*      � .+�5,   
   � .+�5-      � -   5         �Name$ GridBackground��5-      ���	#55313131 J� Opacity$ 0Q�6B   �� 5/      -   5         ��Name$ 
ButtonOpen��5/      $
��Left=�6)   $	��Top=�6D   $��40��6�   $��40��6�   $��0q�6�   ��6\   Z� ��6r   Z� .��50      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$
 Menu=�6*   $��40��66   $��40��6B   ���	#FF3131316M   51      � 52      -   5        $ GridMenu��52      $	��250��6%   $
��Left=�61   $��
-250 0 0 0q�6L   
������� J� RenderTransformOrigin$ 0.5,0.5&�6s   z�53      V� 54      .~�55      �� �� 56      �� 57      T� 58      59      .+�5;      �� .+�5<      �� $	��140��6   $��/Images/unnamed.png��6)   $
��Fill=�6F   �� 5=      ���	#FF313131$��Champagne & Limousines)�66   $��18(�6^   .@�5>      �� $��45��6'   $��0q�63   .��5?      ��  �� Orientation$ 
Horizontal=�6)   $
��10 0q�6B   .+�5@   "     $ Account=�6:   $��20��6I   $��20��6T   
�����_�$��5q�6w   $��Center=�6�   �� 5A   "   $��Thông tin Sinh viên��6,   $��10q�6G   5B      5C      �� 5D      $��45��6'   $��0q�63   .��5E      �� $ 
Horizontal=�6)   $
��10 0q�6B   .+�5F   "     $ PlaylistAdd=�6:   $��20��6M   $��20��6X   ���	#FFF08033$��5q�6{   $��Center=�6�   �� 5G   "   $��Đăng Ký Học Phần��6,   $��10q�6D   5H      5I      �� 5J      $��45��6'   $��0q�63   .��5K      �� $ 
Horizontal=�6)   $
��10 0q�6B   .+�5L   "     $ CalendarText=�6:   $��20��6N   $��20��6Y   
��� � �$��5q�6x   $��Center=�6�   �� 5M   "   $��Lịch Học��6,   $��10q�6<   5N      5O      �� 5P      $��45��6'   $��0q�63   .��5Q      �� $ 
Horizontal=�6)   $
��10 0q�6B   .+�5R   "     $ GridOn=�6:   $��20��6H   $��20��6S   ���	#FFD41515$��5q�6v   $��Center=�6�   �� 5S   "   $��Chương Trình Khung��6,   $��10q�6F   5T      5U      5b      5c      �� 5d      -   5        $ ButtonClose��5d      
���   �$��Right=�6B   $	��Top=�6^   $��30��6�   $��30��6�   $��0q�6�   ��6v   Z� ��6�   Z� .��5e        $ Close=�6.   5f      5h      5i      )   #DangKyHocPhan.Views.DangKyHocPhanUC  5k   
   $��1��6!   $��	 0 50 0 0q�6.   5m      5o      