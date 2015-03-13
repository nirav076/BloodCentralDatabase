/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package bcd;

import java.io.Serializable;
import java.util.Collection;
import javax.persistence.Basic;
import javax.persistence.CascadeType;
import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.Id;
import javax.persistence.NamedQueries;
import javax.persistence.NamedQuery;
import javax.persistence.OneToMany;
import javax.persistence.Table;
import javax.validation.constraints.NotNull;
import javax.validation.constraints.Size;
import javax.xml.bind.annotation.XmlRootElement;
import javax.xml.bind.annotation.XmlTransient;

/**
 *
 * @author Sohil
 */
@Entity
@Table(name = "bloodbanks")
@XmlRootElement
@NamedQueries({
    @NamedQuery(name = "Bloodbanks.findAll", query = "SELECT b FROM Bloodbanks b"),
    @NamedQuery(name = "Bloodbanks.findById", query = "SELECT b FROM Bloodbanks b WHERE b.id = :id"),
    @NamedQuery(name = "Bloodbanks.findByName", query = "SELECT b FROM Bloodbanks b WHERE b.name = :name"),
    @NamedQuery(name = "Bloodbanks.findByAddress", query = "SELECT b FROM Bloodbanks b WHERE b.address = :address"),
    @NamedQuery(name = "Bloodbanks.findByArea", query = "SELECT b FROM Bloodbanks b WHERE b.area = :area"),
    @NamedQuery(name = "Bloodbanks.findByCity", query = "SELECT b FROM Bloodbanks b WHERE b.city = :city"),
    @NamedQuery(name = "Bloodbanks.findByState", query = "SELECT b FROM Bloodbanks b WHERE b.state = :state"),
    @NamedQuery(name = "Bloodbanks.findByContactDetails", query = "SELECT b FROM Bloodbanks b WHERE b.contactDetails = :contactDetails"),
    @NamedQuery(name = "Bloodbanks.findByIncharge", query = "SELECT b FROM Bloodbanks b WHERE b.incharge = :incharge"),
    @NamedQuery(name = "Bloodbanks.findByA1nve", query = "SELECT b FROM Bloodbanks b WHERE b.a1nve = :a1nve"),
    @NamedQuery(name = "Bloodbanks.findByA1pve", query = "SELECT b FROM Bloodbanks b WHERE b.a1pve = :a1pve"),
    @NamedQuery(name = "Bloodbanks.findByA1Bnve", query = "SELECT b FROM Bloodbanks b WHERE b.a1Bnve = :a1Bnve"),
    @NamedQuery(name = "Bloodbanks.findByA1Bpve", query = "SELECT b FROM Bloodbanks b WHERE b.a1Bpve = :a1Bpve"),
    @NamedQuery(name = "Bloodbanks.findByA2nve", query = "SELECT b FROM Bloodbanks b WHERE b.a2nve = :a2nve"),
    @NamedQuery(name = "Bloodbanks.findByA2pve", query = "SELECT b FROM Bloodbanks b WHERE b.a2pve = :a2pve"),
    @NamedQuery(name = "Bloodbanks.findByA2Bnve", query = "SELECT b FROM Bloodbanks b WHERE b.a2Bnve = :a2Bnve"),
    @NamedQuery(name = "Bloodbanks.findByA2Bpve", query = "SELECT b FROM Bloodbanks b WHERE b.a2Bpve = :a2Bpve"),
    @NamedQuery(name = "Bloodbanks.findByBnve", query = "SELECT b FROM Bloodbanks b WHERE b.bnve = :bnve"),
    @NamedQuery(name = "Bloodbanks.findByBpve", query = "SELECT b FROM Bloodbanks b WHERE b.bpve = :bpve"),
    @NamedQuery(name = "Bloodbanks.findByB1pve", query = "SELECT b FROM Bloodbanks b WHERE b.b1pve = :b1pve"),
    @NamedQuery(name = "Bloodbanks.findByOnve", query = "SELECT b FROM Bloodbanks b WHERE b.onve = :onve"),
    @NamedQuery(name = "Bloodbanks.findByOpve", query = "SELECT b FROM Bloodbanks b WHERE b.opve = :opve")})
public class Bloodbanks implements Serializable {
    private static final long serialVersionUID = 1L;
    @Id
    @Basic(optional = false)
    @NotNull
    @Size(min = 1, max = 6)
    @Column(name = "id")
    private String id;
    @Basic(optional = false)
    @NotNull
    @Size(min = 1, max = 50)
    @Column(name = "name")
    private String name;
    @Basic(optional = false)
    @NotNull
    @Size(min = 1, max = 150)
    @Column(name = "address")
    private String address;
    @Basic(optional = false)
    @NotNull
    @Size(min = 1, max = 50)
    @Column(name = "area")
    private String area;
    @Basic(optional = false)
    @NotNull
    @Size(min = 1, max = 30)
    @Column(name = "city")
    private String city;
    @Basic(optional = false)
    @NotNull
    @Size(min = 1, max = 30)
    @Column(name = "state")
    private String state;
    @Basic(optional = false)
    @NotNull
    @Size(min = 1, max = 60)
    @Column(name = "contactDetails")
    private String contactDetails;
    @Basic(optional = false)
    @NotNull
    @Size(min = 1, max = 50)
    @Column(name = "incharge")
    private String incharge;
    @Basic(optional = false)
    @NotNull
    @Column(name = "A1nve")
    private int a1nve;
    @Basic(optional = false)
    @NotNull
    @Column(name = "A1pve")
    private int a1pve;
    @Basic(optional = false)
    @NotNull
    @Column(name = "A1Bnve")
    private int a1Bnve;
    @Basic(optional = false)
    @NotNull
    @Column(name = "A1Bpve")
    private int a1Bpve;
    @Basic(optional = false)
    @NotNull
    @Column(name = "A2nve")
    private int a2nve;
    @Basic(optional = false)
    @NotNull
    @Column(name = "A2pve")
    private int a2pve;
    @Basic(optional = false)
    @NotNull
    @Column(name = "A2Bnve")
    private int a2Bnve;
    @Basic(optional = false)
    @NotNull
    @Column(name = "A2Bpve")
    private int a2Bpve;
    @Basic(optional = false)
    @NotNull
    @Column(name = "Bnve")
    private int bnve;
    @Basic(optional = false)
    @NotNull
    @Column(name = "Bpve")
    private int bpve;
    @Basic(optional = false)
    @NotNull
    @Column(name = "B1pve")
    private int b1pve;
    @Basic(optional = false)
    @NotNull
    @Column(name = "Onve")
    private int onve;
    @Basic(optional = false)
    @NotNull
    @Column(name = "Opve")
    private int opve;
    @OneToMany(cascade = CascadeType.ALL, mappedBy = "associatedWith")
    private Collection<Donors> donorsCollection;

    public Bloodbanks() {
    }

    public Bloodbanks(String id) {
        this.id = id;
    }

    public Bloodbanks(String id, String name, String address, String area, String city, String state, String contactDetails, String incharge, int a1nve, int a1pve, int a1Bnve, int a1Bpve, int a2nve, int a2pve, int a2Bnve, int a2Bpve, int bnve, int bpve, int b1pve, int onve, int opve) {
        this.id = id;
        this.name = name;
        this.address = address;
        this.area = area;
        this.city = city;
        this.state = state;
        this.contactDetails = contactDetails;
        this.incharge = incharge;
        this.a1nve = a1nve;
        this.a1pve = a1pve;
        this.a1Bnve = a1Bnve;
        this.a1Bpve = a1Bpve;
        this.a2nve = a2nve;
        this.a2pve = a2pve;
        this.a2Bnve = a2Bnve;
        this.a2Bpve = a2Bpve;
        this.bnve = bnve;
        this.bpve = bpve;
        this.b1pve = b1pve;
        this.onve = onve;
        this.opve = opve;
    }

    public String getId() {
        return id;
    }

    public void setId(String id) {
        this.id = id;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getAddress() {
        return address;
    }

    public void setAddress(String address) {
        this.address = address;
    }

    public String getArea() {
        return area;
    }

    public void setArea(String area) {
        this.area = area;
    }

    public String getCity() {
        return city;
    }

    public void setCity(String city) {
        this.city = city;
    }

    public String getState() {
        return state;
    }

    public void setState(String state) {
        this.state = state;
    }

    public String getContactDetails() {
        return contactDetails;
    }

    public void setContactDetails(String contactDetails) {
        this.contactDetails = contactDetails;
    }

    public String getIncharge() {
        return incharge;
    }

    public void setIncharge(String incharge) {
        this.incharge = incharge;
    }

    public int getA1nve() {
        return a1nve;
    }

    public void setA1nve(int a1nve) {
        this.a1nve = a1nve;
    }

    public int getA1pve() {
        return a1pve;
    }

    public void setA1pve(int a1pve) {
        this.a1pve = a1pve;
    }

    public int getA1Bnve() {
        return a1Bnve;
    }

    public void setA1Bnve(int a1Bnve) {
        this.a1Bnve = a1Bnve;
    }

    public int getA1Bpve() {
        return a1Bpve;
    }

    public void setA1Bpve(int a1Bpve) {
        this.a1Bpve = a1Bpve;
    }

    public int getA2nve() {
        return a2nve;
    }

    public void setA2nve(int a2nve) {
        this.a2nve = a2nve;
    }

    public int getA2pve() {
        return a2pve;
    }

    public void setA2pve(int a2pve) {
        this.a2pve = a2pve;
    }

    public int getA2Bnve() {
        return a2Bnve;
    }

    public void setA2Bnve(int a2Bnve) {
        this.a2Bnve = a2Bnve;
    }

    public int getA2Bpve() {
        return a2Bpve;
    }

    public void setA2Bpve(int a2Bpve) {
        this.a2Bpve = a2Bpve;
    }

    public int getBnve() {
        return bnve;
    }

    public void setBnve(int bnve) {
        this.bnve = bnve;
    }

    public int getBpve() {
        return bpve;
    }

    public void setBpve(int bpve) {
        this.bpve = bpve;
    }

    public int getB1pve() {
        return b1pve;
    }

    public void setB1pve(int b1pve) {
        this.b1pve = b1pve;
    }

    public int getOnve() {
        return onve;
    }

    public void setOnve(int onve) {
        this.onve = onve;
    }

    public int getOpve() {
        return opve;
    }

    public void setOpve(int opve) {
        this.opve = opve;
    }

    @XmlTransient
    public Collection<Donors> getDonorsCollection() {
        return donorsCollection;
    }

    public void setDonorsCollection(Collection<Donors> donorsCollection) {
        this.donorsCollection = donorsCollection;
    }

    @Override
    public int hashCode() {
        int hash = 0;
        hash += (id != null ? id.hashCode() : 0);
        return hash;
    }

    @Override
    public boolean equals(Object object) {
        // TODO: Warning - this method won't work in the case the id fields are not set
        if (!(object instanceof Bloodbanks)) {
            return false;
        }
        Bloodbanks other = (Bloodbanks) object;
        if ((this.id == null && other.id != null) || (this.id != null && !this.id.equals(other.id))) {
            return false;
        }
        return true;
    }

    @Override
    public String toString() {
        return "bcd.Bloodbanks[ id=" + id + " ]";
    }
    
}
