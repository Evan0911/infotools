@extends('layout')

@section('content')
<!-- partie prospect -->

        <div class="row">
            <div class="col-lg-12 margin-tb">
                <div class="pull-right">
                <!-- un bouton appel la page clients.create -->
                    <a class="btn btn-success" href="{{ route('rdvs.create') }}"> Create New RDV</a>
                </div>
            </div>
        </div>

        <!-- si on reçoit un paramètre succès on affiche un message de succès -->
        @if ($message = Session::get('success'))
            <div class="alert alert-success">
                <p>{{ $message }}</p>
            </div>
        @endif

        <!-- table RDV -->
        <h3> Table RDV </h3>
        <table class="table table-bordered">
            <tr>
            <th>Numéro RDV</th>
                    <th>Nom client</th>
                    <th>Nom prospect</th>
                    <th>Date RDV</th>
                <th width="280px">Action</th>
            </tr>

            <!-- on parcourt la liste clients donné en paramètre
            les crochets servent à remplacer la balise php -->
        @foreach ($rdvs as $rdv)
        <tr>
            <td>{{ $rdv->id }}</td>
            <td>{{ $rdv->client->nomCli . " " . $rdv->client->prenomCli}}</td>
            <td>{{ $rdv->prospect->nomPros . " " . $rdv->prospect->prenomPros}}</td>
            <td>{{ date("d/m/Y H:i:s", strtotime($rdv->dateRdv))}}</td>
            <td>
                <a class="btn btn-info" href="{{ route('rdvs.show',$rdv->id) }}">Show</a>
                <a class="btn btn-primary" href="{{ route('rdvs.edit',$rdv->id) }}">Edit</a>
                <form method= "DELETE" route="[rdvs.destroy,$rdv->id]" style ="display:inline">
                @csrf
                    <a class="btn btn-primary" href="{{ route('rdvs.edit',$rdv->id) }}">Supprimer</a>
                </form>
                <!-- on ouvre un formulaire qui, avec le bouton, supprime le client -->

            </td>
        </tr>
        @endforeach
        </table>

        <div class="row">
            <div class="col-lg-12 margin-tb">
                <div class="pull-right">
                <!-- un bouton appel la page clients.create -->
                    <a class="btn btn-success" href="{{ route('clients.create') }}"> Create New Client</a>
                </div>
            </div>
        </div>


        <!-- table CLIENT -->
        <h3>Table Clients</h3>
        <table class="table table-bordered">
            <tr>
                <th>Numéro Client</th>
                <th>Nom</th>
                <th>Adresse</th>
                <th>Téléphone</th>
                <th>Mail</th>
                <th width="280px">Action</th>
            </tr>

            <!-- on parcourt la liste clients donné en paramètre
            les crochets servent à remplacer la balise php -->
        @foreach ($clients as $client)
        <tr>
            <td>{{ $client->id }}</td>
            <td>{{ $client->nomCli . " " . $client->prenomCli}}</td>
            <td>{{ $client->adresseCli . " " . $client->cpCli . " " . $client->villeCli}}</td>
            <td>{{ $client->telCli }}</td>
            <td>{{ $client->mailCli }}</td>
            <td>
                <a class="btn btn-info" href="{{ route('clients.show',$client->id) }}">Show</a>
                <a class="btn btn-primary" href="{{ route('clients.edit',$client->id) }}">Edit</a>
                <!-- on ouvre un formulaire qui, avec le bouton, supprime le client -->

            </td>
        </tr>
        @endforeach
        </table>

        {!! $clients->links() !!}
@endsection
