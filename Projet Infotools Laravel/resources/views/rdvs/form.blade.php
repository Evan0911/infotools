
<div class="row">
    <div class="col-xs-12 col-sm-12 col-md-12">
        <div class="form-group">
            <strong>Date:</strong>
            <input id="dateRdv" type="date" name="dateRdv">
            <input id='time' type="time" name="time">
        </div>
    </div>
    <div class="col-xs-12 col-sm-12 col-md-12">
        <div class="form-group">
            <strong>Client:</strong>
            <select name='idCli'>
                <option>Choisissez un client</option>
                @foreach($clients as $client)
                <option value='{{$client->id}}'>{{$client->nomCli}} {{$client->prenomCli}}</option>
                @endForeach
            </select>
        </div>
    </div>
    <div class="col-xs-12 col-sm-12 col-md-12">
        <div class="form-group">
            <strong>Prospect:</strong>
            <select name='idPro'>
                <option>Choisissez un prospect</option>
                @foreach($pros as $pro)
                <option value='{{$pro->id}}'>{{$pro->nomPros}} {{$pro->prenomPros}}</option>
                @endForeach
            </select>
        </div>
    </div>
    <div class="col-xs-12 col-sm-12 col-md-12 text-center">
        <button type="submit" class="btn btn-primary">Submit</button>
    </div>
</div>
