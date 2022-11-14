@extends('layout')

@section('content')

    <div class="pull-right">
        <a class="btn btn-primary" href="{{ route('commandes.index') }}"> Back</a>
    </div>
    <!-- table commande -->
    <h3>Commande N°{{$commande->id}} de {{ $commande->client->nomCli . " " .  $commande->client->prenomCli}} faites le {{ $commande->created_at}}</h3>
    <table class="table table-bordered">
        <tr>
            <th>Numéro Produit</th>
            <th>Nom Produit</th>
            <th>Quantité Produit</th>
        </tr>

        <!-- on parcourt la liste commandes donné en paramètre
        les crochets servent à remplacer la balise php -->

    @foreach ($commande->produits as $produit)
    
    <tr>
        <td>{{ $produit->id }}</td>
        <td>{{ $produit->libProd}}</td>
        <td>{{ $produit->pivot->qte}}</td>
    </tr>
    @endforeach
    </table>

@endsection