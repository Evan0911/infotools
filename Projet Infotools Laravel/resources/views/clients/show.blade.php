@extends('layout')

@section('content')
    <div class="pull-right">
        <a class="btn btn-primary" href="{{ route('clients.index') }}"> Back</a>
    </div>
    <!-- table produits acheté -->
    <h3>Produits commandés par le client N°{{$client->id}} : {{ $client->nomCli . " " .  $client->prenomCli}}</h3>
    <table class="table table-bordered">
        <tr>
            <th>Numéro Produit</th>
            <th>Nom Produit</th>
            <th>Quantité Produit</th>
        </tr>

        <!-- on parcourt la liste commandes donné en paramètre
        les crochets servent à remplacer la balise php -->

    @foreach ($commandes as $commande)
        @foreach ($commande->produits as $produit)
        <tr>
            <td>{{ $produit->id }}</td>
            <td>{{ $produit->libProd}}</td>
            <td>{{ $produit->pivot->qte}}</td>
        </tr>
        @endforeach
    @endforeach
    </table>
@endsection