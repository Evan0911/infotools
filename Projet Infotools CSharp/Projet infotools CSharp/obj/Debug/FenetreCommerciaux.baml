   M S B A M L   `   `   `  ����R  NProjet infotools CSharp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:Projet_infotools_CSharpProjet_infotools_CSharp  5   	   0    *Projet_infotools_CSharp.FenetreCommerciaux   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:Projet_infotools_CSharp     5   	     � Title$  FenetreCommerciaux��5   	   $��649.929��6$   $	��971��65   .��5	      � .+�5
   
   �� -   5         ��Name$ 
BtnAjouter��5
      $��Ajouter client��6%   $
��Left=�6>   $	��Top=�6Y   $	��115��6q   $��
838,39,0,0q�6}   $��34��6�   �� 5   
   -   5        $ BtnModifier��5      $��Modifier client��6&   $
��Left=�6@   $	��Top=�6[   $	��115��6s   $��838,158,0,0q�6   $��34��6�   6�   �� 5   
   -   5        $ BtnSupprimer��5      $��Supprimer client��6'   $
��Left=�6B   $	��Top=�6]   $	��115��6u   $��838,270,0,0q�6�   $��34��6�   6�   �� 5   
   -   5         ��Name$ TxtNom��5      $
��Left=�6"   $��23��6=    �� TextWrapping$
 Wrap=�6I   $�� ��6]   $	��Top=�6e   $	��120��6}   $��123,103,0,0q�6�   �� 5   
   -   5        $ 	TxtPrenom��5      $
��Left=�6%   $��23��6@   $
 Wrap=�6L   $�� ��6`   $	��Top=�6h   $	��120��6�   $��356,103,0,0q�6�   �� 5   
   -   5        $ TxtMail��5      $
��Left=�6#   $��23��6>   $
 Wrap=�6J   $�� ��6^   $	��Top=�6f   $	��120��6~   $��578,111,0,0q�6�   �� 5   
   $	��Nom��6   $
��Left=�6   $	��Top=�69   $��
123,72,0,0q�6Q   �� 5   
   $��Prenom��6   $
��Left=�6!   $	��Top=�6<   $��
356,72,0,0q�6T   �� 5   
   $��Adresse mail��6   $
��Left=�6'   $	��Top=�6B   $��
578,80,0,0q�6Z   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ DtgCom��5         AutoGenerateColumns .  $��10,312,161,43q�6W   ��6#   ��    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Numéro��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 66   �� *id+  5      $	 Nom��6%    62   �� *nom+  5      $ Prénom��6%    66   �� *prenom+  5      $ Adresse��6%    66   �� *	adresse+  5      $ Code postal��6%    6:   �� *cp+  5      $ Ville��6%    64   �� *ville+5  /System.Windows.Controls.DataGridHyperlinkColumn  5      $ Email��6*    69   �� *email+5      �� 5   
   -   5        $ 
TxtAdresse��5      $
��Left=�6&   $��23��6A   $
 Wrap=�6M   $�� ��6a   $	��Top=�6i   $	��120��6�   $��123,189,0,0q�6�   �� 5   
   $��Adresse��6   $
��Left=�6"   $	��Top=�6=   $��123,158,0,0q�6U   �� 5    
   -	   5        $ TxtCP��5       $
��Left=�6!   $��23��6<   $
 Wrap=�6H   $�� ��6\   $	��Top=�6d   $	��120��6|   $��356,189,0,0q�6�   �� 5!   
   $��Code postal��6   $
��Left=�6&   $	��Top=�6A   $��356,158,0,0q�6Y   �� 5"   
   -
   5        $ TxtVille��5"      $
��Left=�6$   $��22��6?   $
 Wrap=�6K   $�� ��6_   $	��Top=�6g   $	��120��6   $��578,189,0,0q�6�   �� 5#   
   $��Ville��6   $
��Left=�6    $	��Top=�6;   $��578,158,0,0q�6S   �� 5$   
   -   5        $ TxtMdp��5$      $
��Left=�6"   $��23��6=   $
 Wrap=�6I   $�� ��6]   $	��Top=�6e   $	��120��6}   $��123,264,0,0q�6�   �� 5%   
   $��Mot de passe��6   $
��Left=�6'   $	��Top=�6B   $��123,233,0,0q�6Z   5&      5'      